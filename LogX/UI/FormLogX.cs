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
        OraSession MasterSession { get; set; }
        OraSession TestSession { get; set; }

        public FormLogX() {
            InitializeComponent();
            menuStripLogX.ForeColor = Color.WhiteSmoke;
            menuStripLogX.BackColor = Color.FromArgb(93, 99, 131);
            Connect();
        }

        private void ToolStripMenuItemVersionClick(object sender, EventArgs e) {
            MessageBox.Show(icon: MessageBoxIcon.Information, buttons: MessageBoxButtons.OK,
                caption: "Version", text: "LogX: 1.0\nUpdated " + DateTime.Today.Month + "." + DateTime.Today.Year);
        }

        private void Connect() {
            MasterSession = VerifyConnection("Master");
            TestSession = VerifyConnection("Test");
        }

        private OraSession VerifyConnection(string connectionName) {
            try {
                try {
                    DbConnection connection = DbConnection.DeserializeFromFile(FlatFile.GetDBConfigsFile(), connectionName);
                    OraSession oraSession = new OraSession(connection.CreateConnectionString());
                    InfoMessage.WriteSuccessful(richTextBoxMessages, "Connected to " + connectionName + " database");
                    return oraSession;
                } catch (InvalidOperationException) {
                    InfoMessage.WriteError(richTextBoxMessages, "Failed connect to " + connectionName + ": Connection does not set, please configure it");
                    return null;
                } catch (InvalidDataException) {
                    InfoMessage.WriteError(richTextBoxMessages, "Failed connect to " + connectionName + ": Saved connection has errors, please reconfigure it");
                    return null;
                }
            } catch (Exception ex) {
                InfoMessage.WriteError(richTextBoxMessages, "Failed connect to " + connectionName + ": " + ex.Message);
                return null;
            }
        }
 

        private void ButtonExecuteClick(object sender, EventArgs e) {
            richTextBoxMessages.Text = "Calculating...";
            Queries.LastExecutedBJG();
            richTextBoxMessages.Text = "Finished";
        }

        private void ToolStripMenuItemConnectionClick(object sender, EventArgs e) {
            FormConnections FormConnections = new FormConnections();
            FormConnections.ShowDialog();
        }

        private void ButtonOpenDirClick(object sender, EventArgs e) {
            var OF = new OpenFileDialog {
                InitialDirectory = "C:\\",
                Filter = "All files (*) | *.*"
            };
            if (OF.ShowDialog() == DialogResult.OK) {
                OF.FilterIndex = 0;
                OF.RestoreDirectory = true;
                textBoxResultDir.Text = (OF.FileName);
            }
        }
    }
}
