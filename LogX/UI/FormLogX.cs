using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogX.Controllers;

namespace LogX {
    public partial class FormLogX : Form {
        OraSession OraSession { get; set; }

        public FormLogX() {
            InitializeComponent();
            menuStripLogX.ForeColor = Color.WhiteSmoke;
            menuStripLogX.BackColor = Color.FromArgb(93, 99, 131);
            Connect();
        }

        private void ToolStripMenuItemVersionClick(object sender, EventArgs e) {
            MessageBox.Show(icon: MessageBoxIcon.Information, buttons: MessageBoxButtons.OK,
                caption: "Version", text: "Hope the best version\nLogX: 1.0\nUpdated " + DateTime.Today.Month + "." + DateTime.Today.Year);
        }

        private void Connect() {
            if (File.Exists(FlatFile.CacheFilePath)) {
                try {
                    DbConnection Connection = DbConnection.DeserializeFromFile(FlatFile.CacheFilePath);
                    OraSession = new OraSession(Connection.ConnectionString);
                    string connectionStatus = OraSession.ConnectToDatabase();
                    Message.WriteSuccessful(labelMessages, connectionStatus);
                } catch (Exception ex) {
                    Message.WriteError(labelMessages, ex.Message);
                }
            } else {
                Message.WriteError(labelMessages, "Cache file not found, please configure database connection");
            }
        }

        private void ButtonExecuteClick(object sender, EventArgs e) {
            labelMessages.Text = "Calculating...";
            Queries.LastExecutedBJG();
            labelMessages.Text = "Finished";
        }

        private void ToolStripMenuItemConnectionClick(object sender, EventArgs e) {
            FormConnections FormConnections = new FormConnections();
            FormConnections.ShowDialog();
        }


    }
}
