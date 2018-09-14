using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogX {
    public partial class FormConnections : Form {
        DbConnection Connection { get; set; }
        OraSession OraSession { get; set; }

        public FormConnections() {
            InitializeComponent();
            radioButtonMaster.Select();           
            FillFieldsIfCacheFileExists();
            InitialRadioButtonSelect();
        }

        private void InitialRadioButtonSelect() {
            if (textBoxServiceName.Text != "") {
                radioButtonServiceName.Select();
            }
            else {
                radioButtonSID.Select();
            }
        }

        private void FillFieldsIfCacheFileExists() {
            if (File.Exists(FlatFile.GetCacheFile())) {
                DbConnection connection = DbConnection.DeserializeFromFile(FlatFile.GetCacheFile());
                textBoxHostName.Text = connection.Host;
                textBoxPort.Text = connection.Port;
                textBoxUserName.Text = connection.Schema;
                textBoxPassword.Text = connection.Password;
                textBoxSID.Text = connection.Sid;
                textBoxServiceName.Text = connection.ServiceName;
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
        }

        private void RadioButtonTestCheckedChanged(object sender, EventArgs e) {
            panelConnection.BackColor = Color.FromArgb(219, 195, 138);
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
                Message.WriteError(labelConnectionDetails, "Please fill all available fields");
            } else if (IsTooLongValue()) {
                Message.WriteError(labelConnectionDetails, "Too long value given for one or more parameters");
            } else if (!IsInteger(textBoxPort.Text)) {
                Message.WriteError(labelConnectionDetails, "For Port parameter the integer value is expected");
            } else {
                string host = textBoxHostName.Text;
                string port = textBoxPort.Text;
                string schema = textBoxUserName.Text;
                string password = textBoxPassword.Text;
                string sid = textBoxSID.Text;
                string serviceName = textBoxServiceName.Text;
                Connection = new DbConnection(host, port, schema, password, sid, serviceName);
                OraSession = new OraSession(Connection.CreateConnectionString());
                try {
                    string connectionStatus = OraSession.ConnectToDatabase();
                    Message.WriteSuccessful(labelConnectionDetails, connectionStatus);
                } catch (Exception ex) {
                    Message.WriteError(labelConnectionDetails, ex.Message);
                }
            }
        }

        private void ButtonSaveClick(object sender, EventArgs e) {
            if (IsAnyTextBoxEmpty()) {
                Message.WriteError(labelConnectionDetails, "Please fill all available fields and then test your connection");
            } else if (Connection != null) {
                Connection.SerializeToFile(FlatFile.GetCacheFile());
                Message.WriteSuccessful(labelConnectionDetails, "Saved");
            } else {
                Message.WriteError(labelConnectionDetails, "Firstly test your connection");
            }
        }
    }

}
