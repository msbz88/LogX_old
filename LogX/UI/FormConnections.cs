using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LogX {
    public partial class FormConnections : Form {
        DbConnection Connection { get; set; }
        OraSession OraSession { get; set; }

        public FormConnections() {
            InitializeComponent();
            radioButtonMaster.Select();
            radioButtonSID.Select();
        }

        private void GetConnectionInfoFromFile(string connectionName) {
            try {
                DbConnection connection = DbConnection.DeserializeFromFile(FlatFile.GetDBConfigsFile(), connectionName);
                textBoxHostName.Text = connection.Host;
                textBoxPort.Text = connection.Port;
                textBoxUserName.Text = connection.Schema;
                textBoxPassword.Text = connection.Password;
                textBoxSID.Text = connection.Sid;
                textBoxServiceName.Text = connection.ServiceName;
            } catch (InvalidOperationException) {
                //InfoMessage.WriteError(labelConnectionDetails, "Connection to database does not set, please configure it");
                return;
            } catch (InvalidDataException) {
                InfoMessage.WriteError(labelConnectionDetails, connectionName + " connection has errors and need to be reconfigured");
                ClearAllTextBoxes();
                return;
            } catch (NullReferenceException) {
                InfoMessage.WriteError(labelConnectionDetails, connectionName + " connection not found. Please configure it");
                ClearAllTextBoxes();
                return;
            }
            if (textBoxServiceName.Text != "") {
                radioButtonServiceName.Select();
            } else {
                radioButtonSID.Select();
            }
            if (IsAnyTextBoxEmpty()) {
                InfoMessage.WriteError(labelConnectionDetails, "Some data was lost for " + connectionName + " connection. Please correct it" );
            }
        }

        private void ClearAllTextBoxes() {
            foreach (Control c in panelConnection.Controls) {
                if (c is TextBox) {
                    c.Text = "";
                }
            }
        }

        private void RadioButtonSIDCheckedChanged(object sender, EventArgs e) {
            textBoxServiceName.Enabled = false;
            textBoxSID.Enabled = true;
        }

        private void RadioButtonServiceNameCheckedChanged(object sender, EventArgs e) {
            textBoxSID.Enabled = false;
            textBoxServiceName.Enabled = true;
        }

        private bool IsAnyTextBoxEmpty() {
            foreach (Control c in panelConnection.Controls) {
                if (c is TextBox) {
                    if (c.Text == "" && c.Enabled == true) return true;
                }
            }
            return false;
        }

        private void RadioButtonMasterCheckedChanged(object sender, EventArgs e) {
            panelConnection.BackColor = Color.FromArgb(147, 162, 189);
            GetConnectionInfoFromFile("Master");
        }

        private void RadioButtonTestCheckedChanged(object sender, EventArgs e) {
            panelConnection.BackColor = Color.FromArgb(219, 195, 138);
            GetConnectionInfoFromFile("Test");
        }

        private bool IsInteger(string input) {
            return int.TryParse(input, out int n);
        }

        private bool IsTooLongValue() {
            foreach (Control c in panelConnection.Controls) {
                if (c is TextBox) {
                    if (c.Text.Length > 100 && c.Enabled == true) return true;
                }
            }
            return false;
        }

        private void ButtonTestClick(object sender, EventArgs e) {
            if (IsAnyTextBoxEmpty()) {
                InfoMessage.WriteError(labelConnectionDetails, "Please fill all available fields");
            } else if (IsTooLongValue()) {
                InfoMessage.WriteError(labelConnectionDetails, "Too long value given for one or more parameters");
            } else if (!IsInteger(textBoxPort.Text)) {
                InfoMessage.WriteError(labelConnectionDetails, "For Port parameter the integer value is expected");
            } else {
                string connectionName = "";
                if (radioButtonMaster.Checked) {
                    connectionName = "Master";
                } else { connectionName = "Test"; }
                string host = textBoxHostName.Text;
                string port = textBoxPort.Text;
                string schema = textBoxUserName.Text;
                string password = textBoxPassword.Text;
                string sid = textBoxSID.Text;
                string serviceName = textBoxServiceName.Text;
                Connection = new DbConnection(connectionName, host, port, schema, password, sid, serviceName);                
                try {
                    OraSession = new OraSession(Connection.CreateConnectionString());
                    InfoMessage.WriteSuccessful(labelConnectionDetails, "Connected to " + connectionName + " database");
                } catch (Exception ex) {
                    // Connection = null;
                    InfoMessage.WriteError(labelConnectionDetails, ex.Message);
                }
            }
        }

        private void ButtonSaveClick(object sender, EventArgs e) {
            if (IsAnyTextBoxEmpty()) {
                InfoMessage.WriteError(labelConnectionDetails, "Please fill all available fields and then test your connection");
            } else if (Connection != null) {
                Connection.SerializeToFile(FlatFile.GetDBConfigsFile());
                InfoMessage.WriteSuccessful(labelConnectionDetails, "Saved");
            } else {
                InfoMessage.WriteError(labelConnectionDetails, "Firstly test your connection. Only successful connection can be saved");
            }
        }
    }

}
