using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LogX.Views {
    public partial class FormDbConnections : Form, IDbConnectionView {
        public string ConnectionName { get; set; }
        public string Host { get { return textBoxHostName.Text; } set { textBoxHostName.Text = value; } }
        public string Port { get { return textBoxPort.Text; } set { textBoxPort.Text = value; } }
        public string Schema { get { return textBoxUserName.Text; } set { textBoxUserName.Text = value; } }
        public string Password { get { return textBoxPassword.Text; } set { textBoxPassword.Text = value; } }
        public string Sid { get { return textBoxSID.Text; } set { textBoxSID.Text = value; } }
        public string ServiceName { get { return textBoxServiceName.Text; } set { textBoxServiceName.Text = value; } }
        public bool IsMasterActive { get; set; }
        public bool IsTestActive { get; set; }

        Timer Timer = new Timer();
        object objectLock = new Object();

        public FormDbConnections() {
            InitializeComponent();
            radioButtonMaster.Select();
            radioButtonSID.Select();
        }

        event EventHandler IDbConnectionView.TestConnectionEvent {
            add {
                lock (objectLock) {
                    buttonTest.Click += value;
                }
            }
            remove {
                lock (objectLock) {
                    buttonTest.Click -= value;
                }
            }
        }

        event EventHandler IDbConnectionView.SaveConnectionEvent {
            add {
                lock (objectLock) {
                    buttonSave.Click += value;
                }
            }
            remove {
                lock (objectLock) {
                    buttonSave.Click -= value;
                }
            }
        }

        public void WriteSuccessful(string message) {
            labelConnInfoMessages.ForeColor = Color.Green;
            labelConnInfoMessages.Text = message;
            ClearTimer();
        }

        public void WriteError(string message) {
            labelConnInfoMessages.ForeColor = Color.Red;
            labelConnInfoMessages.Text = message;
            ClearTimer();
        }

        private void ClearTimer() {
            Timer.Stop();
            Timer.Interval = 10000;
            Timer.Tick += (s, e) => {
                Timer.Stop();
                labelConnInfoMessages.Text = "";
                labelConnInfoMessages.ForeColor = Color.Black;
            };
            Timer.Start();
        }

        private void RadioButtonSIDCheckedChanged(object sender, EventArgs e) {
            textBoxServiceName.Enabled = false;
            textBoxSID.Enabled = true;
        }

        private void RadioButtonServiceNameCheckedChanged(object sender, EventArgs e) {
            textBoxSID.Enabled = false;
            textBoxServiceName.Enabled = true;
        }

        private void RadioButtonMasterCheckedChanged(object sender, EventArgs e) {
            panelConnection.BackColor = Color.FromArgb(147, 162, 189);
            IsMasterActive = true;
            IsTestActive = false;
            //ClearAllTextBoxes();
        }

        private void RadioButtonTestCheckedChanged(object sender, EventArgs e) {
            panelConnection.BackColor = Color.FromArgb(219, 195, 138);
            //ClearAllTextBoxes();
            IsMasterActive = false;
            IsTestActive = true;
        }

        public void ClearAllTextBoxes() {
            foreach (Control c in panelConnection.Controls) {
                if (c is TextBox) {
                    c.Text = "";
                }
            }
        }
    }
}
