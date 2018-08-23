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
                string host = textBoxHostName.Text;
                string port = textBoxPort.Text;               
                string schema = textBoxUserName.Text;
                string password = textBoxUserName.Text;
                string sid = textBoxSID.Text;
                string serviceName = textBoxServiceName.Text;

                Connection Connection = new Connection(host, port, schema, password, sid, serviceName);
                OraSession = new OraSession(Connection.String);
                textBoxConnectionDetails.Text = OraSession.TryConnect();
            } else {
                textBoxConnectionDetails.Text = "You are already connected to database";
            }
        }

     
    }
}
