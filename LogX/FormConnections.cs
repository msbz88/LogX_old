using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogX {
    public partial class FormConnections : Form {
        Connection Connection { get; set; }
        OraSession OraSession { get; set; }

        public FormConnections() {
            InitializeComponent();
            radioButtonMaster.Select();
            radioButtonSID.Select();
        }

        private void ButtonTestClick(object sender, EventArgs e) {
            if (IsAnyTextBoxEmpty()) {
                Message.WriteError(labelConnectionDetails, "Please fill all available fields");
            } else {
                string host = textBoxHostName.Text;
                string port = textBoxPort.Text;
                string schema = textBoxUserName.Text;
                string password = textBoxUserName.Text;
                string sid = textBoxSID.Text;
                string serviceName = textBoxServiceName.Text;
                Connection Connection = new Connection(host, port, schema, password, sid, serviceName);
                OraSession = new OraSession(Connection.String);
                try {
                    Message.WriteSuccessful(labelConnectionDetails, OraSession.ConnectToDatabase());
                } catch (Exception ex) {
                    Message.WriteError(labelConnectionDetails, ex.ToString());
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




    }

}
