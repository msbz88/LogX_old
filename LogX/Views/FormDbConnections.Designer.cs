namespace LogX.Views {
    partial class FormDbConnections {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDbConnections));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.radioButtonMaster = new System.Windows.Forms.RadioButton();
            this.radioButtonTest = new System.Windows.Forms.RadioButton();
            this.labelConnInfoMessages = new System.Windows.Forms.Label();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.radioButtonServiceName = new System.Windows.Forms.RadioButton();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.radioButtonSID = new System.Windows.Forms.RadioButton();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelHostName = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSID = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.panelConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(194, 312);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(113, 312);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 12;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster
            // 
            this.radioButtonMaster.AutoSize = true;
            this.radioButtonMaster.Location = new System.Drawing.Point(131, 12);
            this.radioButtonMaster.Name = "radioButtonMaster";
            this.radioButtonMaster.Size = new System.Drawing.Size(57, 17);
            this.radioButtonMaster.TabIndex = 17;
            this.radioButtonMaster.TabStop = true;
            this.radioButtonMaster.Text = "Master";
            this.radioButtonMaster.UseVisualStyleBackColor = true;
            this.radioButtonMaster.CheckedChanged += new System.EventHandler(this.RadioButtonMasterCheckedChanged);
            // 
            // radioButtonTest
            // 
            this.radioButtonTest.AutoSize = true;
            this.radioButtonTest.Location = new System.Drawing.Point(212, 13);
            this.radioButtonTest.Name = "radioButtonTest";
            this.radioButtonTest.Size = new System.Drawing.Size(46, 17);
            this.radioButtonTest.TabIndex = 18;
            this.radioButtonTest.TabStop = true;
            this.radioButtonTest.Text = "Test";
            this.radioButtonTest.UseVisualStyleBackColor = true;
            this.radioButtonTest.CheckedChanged += new System.EventHandler(this.RadioButtonTestCheckedChanged);
            // 
            // labelConnInfoMessages
            // 
            this.labelConnInfoMessages.AutoSize = true;
            this.labelConnInfoMessages.Location = new System.Drawing.Point(12, 339);
            this.labelConnInfoMessages.Name = "labelConnInfoMessages";
            this.labelConnInfoMessages.Size = new System.Drawing.Size(0, 13);
            this.labelConnInfoMessages.TabIndex = 19;
            // 
            // panelConnection
            // 
            this.panelConnection.Controls.Add(this.textBoxUserName);
            this.panelConnection.Controls.Add(this.radioButtonServiceName);
            this.panelConnection.Controls.Add(this.labelPassword);
            this.panelConnection.Controls.Add(this.textBoxHostName);
            this.panelConnection.Controls.Add(this.radioButtonSID);
            this.panelConnection.Controls.Add(this.labelUserName);
            this.panelConnection.Controls.Add(this.labelHostName);
            this.panelConnection.Controls.Add(this.textBoxServiceName);
            this.panelConnection.Controls.Add(this.textBoxPort);
            this.panelConnection.Controls.Add(this.textBoxPassword);
            this.panelConnection.Controls.Add(this.textBoxSID);
            this.panelConnection.Controls.Add(this.labelPort);
            this.panelConnection.Location = new System.Drawing.Point(6, 36);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(379, 270);
            this.panelConnection.TabIndex = 16;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(6, 24);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(368, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // radioButtonServiceName
            // 
            this.radioButtonServiceName.AutoSize = true;
            this.radioButtonServiceName.Location = new System.Drawing.Point(6, 216);
            this.radioButtonServiceName.Name = "radioButtonServiceName";
            this.radioButtonServiceName.Size = new System.Drawing.Size(92, 17);
            this.radioButtonServiceName.TabIndex = 11;
            this.radioButtonServiceName.TabStop = true;
            this.radioButtonServiceName.Text = "Service Name";
            this.radioButtonServiceName.UseVisualStyleBackColor = true;
            this.radioButtonServiceName.CheckedChanged += new System.EventHandler(this.RadioButtonServiceNameCheckedChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(3, 47);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.Location = new System.Drawing.Point(6, 102);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(368, 20);
            this.textBoxHostName.TabIndex = 4;
            // 
            // radioButtonSID
            // 
            this.radioButtonSID.AutoSize = true;
            this.radioButtonSID.Location = new System.Drawing.Point(6, 167);
            this.radioButtonSID.Name = "radioButtonSID";
            this.radioButtonSID.Size = new System.Drawing.Size(43, 17);
            this.radioButtonSID.TabIndex = 10;
            this.radioButtonSID.TabStop = true;
            this.radioButtonSID.Text = "SID";
            this.radioButtonSID.UseVisualStyleBackColor = true;
            this.radioButtonSID.CheckedChanged += new System.EventHandler(this.RadioButtonSIDCheckedChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(3, 8);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.Location = new System.Drawing.Point(3, 86);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(60, 13);
            this.labelHostName.TabIndex = 5;
            this.labelHostName.Text = "Host Name";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(6, 239);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(368, 20);
            this.textBoxServiceName.TabIndex = 9;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(6, 141);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(368, 20);
            this.textBoxPort.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 63);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(368, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxSID
            // 
            this.textBoxSID.Location = new System.Drawing.Point(6, 190);
            this.textBoxSID.Name = "textBoxSID";
            this.textBoxSID.Size = new System.Drawing.Size(368, 20);
            this.textBoxSID.TabIndex = 8;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(3, 125);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 7;
            this.labelPort.Text = "Port";
            // 
            // FormDbConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(389, 361);
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.labelConnInfoMessages);
            this.Controls.Add(this.radioButtonTest);
            this.Controls.Add(this.radioButtonMaster);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDbConnections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connections";
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.RadioButton radioButtonMaster;
        private System.Windows.Forms.RadioButton radioButtonTest;
        private System.Windows.Forms.Label labelConnInfoMessages;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.RadioButton radioButtonServiceName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.RadioButton radioButtonSID;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSID;
        private System.Windows.Forms.Label labelPort;
    }
}