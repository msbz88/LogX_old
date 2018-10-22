﻿using Oracle.ManagedDataAccess.Client;
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
                caption: "Version", text: "LogX: 1.0\nUpdated " + DateTime.Today.Month + "." + DateTime.Today.Year);
        }

        private void Connect() {
            if (File.Exists(FlatFile.GetDBConfigsFile())) {
                try {
                    DbConnection connection = DbConnection.DeserializeFromFile(FlatFile.GetDBConfigsFile(), "Master");
                    OraSession = new OraSession(connection.CreateConnectionString());
                    string connectionStatus = OraSession.ConnectToDatabase();
                    InfoMessage.WriteSuccessful(labelMessages, connectionStatus);
                } catch (Exception) {
                }
            } else {
                InfoMessage.WriteError(labelMessages, "Connections to databases do not set, please configure them");
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
