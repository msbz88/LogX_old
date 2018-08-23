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
        }

        private void ButtonTestClick(object sender, EventArgs e) {
            if (OraSession == null) {
                string host = textBoxMasterHostName.Text;
                string port = textBoxMasterPort.Text;               
                string schema = textBoxMasterUserName.Text;
                string password = textBoxMasterUserName.Text;
                string sid = textBoxMasterSID.Text;
                string serviceName = textBoxMasterServiceName.Text;

                Connection Connection = new Connection(host, port, schema, password, sid, serviceName);
                OraSession = new OraSession(Connection.String);
                textBoxConnectionDetails.Text = OraSession.TryConnect();
            }
        }
    }
}
