namespace LogX {
    partial class FormConnections {
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
            this.tabControlConnections = new System.Windows.Forms.TabControl();
            this.tabPageMaster = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.radioButtonMasterServiceName = new System.Windows.Forms.RadioButton();
            this.radioButtonMasterSID = new System.Windows.Forms.RadioButton();
            this.textBoxMasterServiceName = new System.Windows.Forms.TextBox();
            this.textBoxMasterSID = new System.Windows.Forms.TextBox();
            this.labelMasterPort = new System.Windows.Forms.Label();
            this.textBoxMasterPort = new System.Windows.Forms.TextBox();
            this.labelMasterHostName = new System.Windows.Forms.Label();
            this.textBoxMasterHostName = new System.Windows.Forms.TextBox();
            this.labelMasterPassword = new System.Windows.Forms.Label();
            this.textBoxMasterPassword = new System.Windows.Forms.TextBox();
            this.labelMasterUserName = new System.Windows.Forms.Label();
            this.textBoxMasterUserName = new System.Windows.Forms.TextBox();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.radioButtonTestServiceName = new System.Windows.Forms.RadioButton();
            this.radioButtonTestSID = new System.Windows.Forms.RadioButton();
            this.textBoxTestServiceName = new System.Windows.Forms.TextBox();
            this.textBoxTestSID = new System.Windows.Forms.TextBox();
            this.labelTestPort = new System.Windows.Forms.Label();
            this.textBoxTestPort = new System.Windows.Forms.TextBox();
            this.labelTestHostName = new System.Windows.Forms.Label();
            this.textBoxTestHostName = new System.Windows.Forms.TextBox();
            this.labelTestPassword = new System.Windows.Forms.Label();
            this.textBoxTestPassword = new System.Windows.Forms.TextBox();
            this.labelTestUserName = new System.Windows.Forms.Label();
            this.textBoxTestUserName = new System.Windows.Forms.TextBox();
            this.textBoxConnectionDetails = new System.Windows.Forms.TextBox();
            this.tabControlConnections.SuspendLayout();
            this.tabPageMaster.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConnections
            // 
            this.tabControlConnections.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlConnections.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlConnections.Controls.Add(this.tabPageMaster);
            this.tabControlConnections.Controls.Add(this.tabPageTest);
            this.tabControlConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlConnections.Location = new System.Drawing.Point(12, 3);
            this.tabControlConnections.Multiline = true;
            this.tabControlConnections.Name = "tabControlConnections";
            this.tabControlConnections.SelectedIndex = 0;
            this.tabControlConnections.Size = new System.Drawing.Size(580, 195);
            this.tabControlConnections.TabIndex = 0;
            // 
            // tabPageMaster
            // 
            this.tabPageMaster.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageMaster.Controls.Add(this.radioButtonMasterServiceName);
            this.tabPageMaster.Controls.Add(this.radioButtonMasterSID);
            this.tabPageMaster.Controls.Add(this.textBoxMasterServiceName);
            this.tabPageMaster.Controls.Add(this.textBoxMasterSID);
            this.tabPageMaster.Controls.Add(this.labelMasterPort);
            this.tabPageMaster.Controls.Add(this.textBoxMasterPort);
            this.tabPageMaster.Controls.Add(this.labelMasterHostName);
            this.tabPageMaster.Controls.Add(this.textBoxMasterHostName);
            this.tabPageMaster.Controls.Add(this.labelMasterPassword);
            this.tabPageMaster.Controls.Add(this.textBoxMasterPassword);
            this.tabPageMaster.Controls.Add(this.labelMasterUserName);
            this.tabPageMaster.Controls.Add(this.textBoxMasterUserName);
            this.tabPageMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageMaster.Location = new System.Drawing.Point(95, 4);
            this.tabPageMaster.Name = "tabPageMaster";
            this.tabPageMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaster.Size = new System.Drawing.Size(481, 187);
            this.tabPageMaster.TabIndex = 0;
            this.tabPageMaster.Text = "Master";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(205, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(107, 200);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 12;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.ButtonTestClick);
            // 
            // radioButtonMasterServiceName
            // 
            this.radioButtonMasterServiceName.AutoSize = true;
            this.radioButtonMasterServiceName.Location = new System.Drawing.Point(22, 158);
            this.radioButtonMasterServiceName.Name = "radioButtonMasterServiceName";
            this.radioButtonMasterServiceName.Size = new System.Drawing.Size(92, 17);
            this.radioButtonMasterServiceName.TabIndex = 11;
            this.radioButtonMasterServiceName.TabStop = true;
            this.radioButtonMasterServiceName.Text = "Service Name";
            this.radioButtonMasterServiceName.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasterSID
            // 
            this.radioButtonMasterSID.AutoSize = true;
            this.radioButtonMasterSID.Location = new System.Drawing.Point(22, 132);
            this.radioButtonMasterSID.Name = "radioButtonMasterSID";
            this.radioButtonMasterSID.Size = new System.Drawing.Size(43, 17);
            this.radioButtonMasterSID.TabIndex = 10;
            this.radioButtonMasterSID.TabStop = true;
            this.radioButtonMasterSID.Text = "SID";
            this.radioButtonMasterSID.UseVisualStyleBackColor = true;
            // 
            // textBoxMasterServiceName
            // 
            this.textBoxMasterServiceName.Location = new System.Drawing.Point(117, 155);
            this.textBoxMasterServiceName.Name = "textBoxMasterServiceName";
            this.textBoxMasterServiceName.Size = new System.Drawing.Size(350, 20);
            this.textBoxMasterServiceName.TabIndex = 9;
            // 
            // textBoxMasterSID
            // 
            this.textBoxMasterSID.Location = new System.Drawing.Point(117, 129);
            this.textBoxMasterSID.Name = "textBoxMasterSID";
            this.textBoxMasterSID.Size = new System.Drawing.Size(350, 20);
            this.textBoxMasterSID.TabIndex = 8;
            // 
            // labelMasterPort
            // 
            this.labelMasterPort.AutoSize = true;
            this.labelMasterPort.Location = new System.Drawing.Point(19, 110);
            this.labelMasterPort.Name = "labelMasterPort";
            this.labelMasterPort.Size = new System.Drawing.Size(26, 13);
            this.labelMasterPort.TabIndex = 7;
            this.labelMasterPort.Text = "Port";
            // 
            // textBoxMasterPort
            // 
            this.textBoxMasterPort.Location = new System.Drawing.Point(117, 103);
            this.textBoxMasterPort.Name = "textBoxMasterPort";
            this.textBoxMasterPort.Size = new System.Drawing.Size(350, 20);
            this.textBoxMasterPort.TabIndex = 6;
            // 
            // labelMasterHostName
            // 
            this.labelMasterHostName.AutoSize = true;
            this.labelMasterHostName.Location = new System.Drawing.Point(19, 84);
            this.labelMasterHostName.Name = "labelMasterHostName";
            this.labelMasterHostName.Size = new System.Drawing.Size(60, 13);
            this.labelMasterHostName.TabIndex = 5;
            this.labelMasterHostName.Text = "Host Name";
            // 
            // textBoxMasterHostName
            // 
            this.textBoxMasterHostName.Location = new System.Drawing.Point(117, 77);
            this.textBoxMasterHostName.Name = "textBoxMasterHostName";
            this.textBoxMasterHostName.Size = new System.Drawing.Size(350, 20);
            this.textBoxMasterHostName.TabIndex = 4;
            // 
            // labelMasterPassword
            // 
            this.labelMasterPassword.AutoSize = true;
            this.labelMasterPassword.Location = new System.Drawing.Point(19, 41);
            this.labelMasterPassword.Name = "labelMasterPassword";
            this.labelMasterPassword.Size = new System.Drawing.Size(53, 13);
            this.labelMasterPassword.TabIndex = 3;
            this.labelMasterPassword.Text = "Password";
            // 
            // textBoxMasterPassword
            // 
            this.textBoxMasterPassword.Location = new System.Drawing.Point(117, 34);
            this.textBoxMasterPassword.Name = "textBoxMasterPassword";
            this.textBoxMasterPassword.Size = new System.Drawing.Size(350, 20);
            this.textBoxMasterPassword.TabIndex = 2;
            // 
            // labelMasterUserName
            // 
            this.labelMasterUserName.AutoSize = true;
            this.labelMasterUserName.Location = new System.Drawing.Point(19, 15);
            this.labelMasterUserName.Name = "labelMasterUserName";
            this.labelMasterUserName.Size = new System.Drawing.Size(60, 13);
            this.labelMasterUserName.TabIndex = 1;
            this.labelMasterUserName.Text = "User Name";
            // 
            // textBoxMasterUserName
            // 
            this.textBoxMasterUserName.Location = new System.Drawing.Point(117, 8);
            this.textBoxMasterUserName.Name = "textBoxMasterUserName";
            this.textBoxMasterUserName.Size = new System.Drawing.Size(350, 20);
            this.textBoxMasterUserName.TabIndex = 0;
            // 
            // tabPageTest
            // 
            this.tabPageTest.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageTest.Controls.Add(this.radioButtonTestServiceName);
            this.tabPageTest.Controls.Add(this.radioButtonTestSID);
            this.tabPageTest.Controls.Add(this.textBoxTestServiceName);
            this.tabPageTest.Controls.Add(this.textBoxTestSID);
            this.tabPageTest.Controls.Add(this.labelTestPort);
            this.tabPageTest.Controls.Add(this.textBoxTestPort);
            this.tabPageTest.Controls.Add(this.labelTestHostName);
            this.tabPageTest.Controls.Add(this.textBoxTestHostName);
            this.tabPageTest.Controls.Add(this.labelTestPassword);
            this.tabPageTest.Controls.Add(this.textBoxTestPassword);
            this.tabPageTest.Controls.Add(this.labelTestUserName);
            this.tabPageTest.Controls.Add(this.textBoxTestUserName);
            this.tabPageTest.Location = new System.Drawing.Point(95, 4);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(481, 187);
            this.tabPageTest.TabIndex = 1;
            this.tabPageTest.Text = "Test";
            // 
            // radioButtonTestServiceName
            // 
            this.radioButtonTestServiceName.AutoSize = true;
            this.radioButtonTestServiceName.Location = new System.Drawing.Point(22, 158);
            this.radioButtonTestServiceName.Name = "radioButtonTestServiceName";
            this.radioButtonTestServiceName.Size = new System.Drawing.Size(92, 17);
            this.radioButtonTestServiceName.TabIndex = 23;
            this.radioButtonTestServiceName.TabStop = true;
            this.radioButtonTestServiceName.Text = "Service Name";
            this.radioButtonTestServiceName.UseVisualStyleBackColor = true;
            // 
            // radioButtonTestSID
            // 
            this.radioButtonTestSID.AutoSize = true;
            this.radioButtonTestSID.Location = new System.Drawing.Point(22, 132);
            this.radioButtonTestSID.Name = "radioButtonTestSID";
            this.radioButtonTestSID.Size = new System.Drawing.Size(43, 17);
            this.radioButtonTestSID.TabIndex = 22;
            this.radioButtonTestSID.TabStop = true;
            this.radioButtonTestSID.Text = "SID";
            this.radioButtonTestSID.UseVisualStyleBackColor = true;
            // 
            // textBoxTestServiceName
            // 
            this.textBoxTestServiceName.Location = new System.Drawing.Point(117, 155);
            this.textBoxTestServiceName.Name = "textBoxTestServiceName";
            this.textBoxTestServiceName.Size = new System.Drawing.Size(350, 20);
            this.textBoxTestServiceName.TabIndex = 21;
            // 
            // textBoxTestSID
            // 
            this.textBoxTestSID.Location = new System.Drawing.Point(117, 129);
            this.textBoxTestSID.Name = "textBoxTestSID";
            this.textBoxTestSID.Size = new System.Drawing.Size(350, 20);
            this.textBoxTestSID.TabIndex = 20;
            // 
            // labelTestPort
            // 
            this.labelTestPort.AutoSize = true;
            this.labelTestPort.Location = new System.Drawing.Point(19, 110);
            this.labelTestPort.Name = "labelTestPort";
            this.labelTestPort.Size = new System.Drawing.Size(26, 13);
            this.labelTestPort.TabIndex = 19;
            this.labelTestPort.Text = "Port";
            // 
            // textBoxTestPort
            // 
            this.textBoxTestPort.Location = new System.Drawing.Point(117, 103);
            this.textBoxTestPort.Name = "textBoxTestPort";
            this.textBoxTestPort.Size = new System.Drawing.Size(350, 20);
            this.textBoxTestPort.TabIndex = 18;
            // 
            // labelTestHostName
            // 
            this.labelTestHostName.AutoSize = true;
            this.labelTestHostName.Location = new System.Drawing.Point(19, 84);
            this.labelTestHostName.Name = "labelTestHostName";
            this.labelTestHostName.Size = new System.Drawing.Size(60, 13);
            this.labelTestHostName.TabIndex = 17;
            this.labelTestHostName.Text = "Host Name";
            // 
            // textBoxTestHostName
            // 
            this.textBoxTestHostName.Location = new System.Drawing.Point(117, 77);
            this.textBoxTestHostName.Name = "textBoxTestHostName";
            this.textBoxTestHostName.Size = new System.Drawing.Size(350, 20);
            this.textBoxTestHostName.TabIndex = 16;
            // 
            // labelTestPassword
            // 
            this.labelTestPassword.AutoSize = true;
            this.labelTestPassword.Location = new System.Drawing.Point(19, 41);
            this.labelTestPassword.Name = "labelTestPassword";
            this.labelTestPassword.Size = new System.Drawing.Size(53, 13);
            this.labelTestPassword.TabIndex = 15;
            this.labelTestPassword.Text = "Password";
            // 
            // textBoxTestPassword
            // 
            this.textBoxTestPassword.Location = new System.Drawing.Point(117, 34);
            this.textBoxTestPassword.Name = "textBoxTestPassword";
            this.textBoxTestPassword.Size = new System.Drawing.Size(350, 20);
            this.textBoxTestPassword.TabIndex = 14;
            // 
            // labelTestUserName
            // 
            this.labelTestUserName.AutoSize = true;
            this.labelTestUserName.Location = new System.Drawing.Point(19, 15);
            this.labelTestUserName.Name = "labelTestUserName";
            this.labelTestUserName.Size = new System.Drawing.Size(60, 13);
            this.labelTestUserName.TabIndex = 13;
            this.labelTestUserName.Text = "User Name";
            // 
            // textBoxTestUserName
            // 
            this.textBoxTestUserName.Location = new System.Drawing.Point(117, 8);
            this.textBoxTestUserName.Name = "textBoxTestUserName";
            this.textBoxTestUserName.Size = new System.Drawing.Size(350, 20);
            this.textBoxTestUserName.TabIndex = 12;
            // 
            // textBoxConnectionDetails
            // 
            this.textBoxConnectionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectionDetails.Location = new System.Drawing.Point(12, 229);
            this.textBoxConnectionDetails.Name = "textBoxConnectionDetails";
            this.textBoxConnectionDetails.ReadOnly = true;
            this.textBoxConnectionDetails.Size = new System.Drawing.Size(576, 13);
            this.textBoxConnectionDetails.TabIndex = 1;
            this.textBoxConnectionDetails.TabStop = false;
            // 
            // FormConnections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 251);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxConnectionDetails);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.tabControlConnections);
            this.Name = "FormConnections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connections";
            this.tabControlConnections.ResumeLayout(false);
            this.tabPageMaster.ResumeLayout(false);
            this.tabPageMaster.PerformLayout();
            this.tabPageTest.ResumeLayout(false);
            this.tabPageTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConnections;
        private System.Windows.Forms.TabPage tabPageMaster;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.RadioButton radioButtonMasterServiceName;
        private System.Windows.Forms.RadioButton radioButtonMasterSID;
        private System.Windows.Forms.TextBox textBoxMasterServiceName;
        private System.Windows.Forms.TextBox textBoxMasterSID;
        private System.Windows.Forms.Label labelMasterPort;
        private System.Windows.Forms.TextBox textBoxMasterPort;
        private System.Windows.Forms.Label labelMasterHostName;
        private System.Windows.Forms.TextBox textBoxMasterHostName;
        private System.Windows.Forms.Label labelMasterPassword;
        private System.Windows.Forms.TextBox textBoxMasterPassword;
        private System.Windows.Forms.Label labelMasterUserName;
        private System.Windows.Forms.TextBox textBoxMasterUserName;
        private System.Windows.Forms.RadioButton radioButtonTestServiceName;
        private System.Windows.Forms.RadioButton radioButtonTestSID;
        private System.Windows.Forms.TextBox textBoxTestServiceName;
        private System.Windows.Forms.TextBox textBoxTestSID;
        private System.Windows.Forms.Label labelTestPort;
        private System.Windows.Forms.TextBox textBoxTestPort;
        private System.Windows.Forms.Label labelTestHostName;
        private System.Windows.Forms.TextBox textBoxTestHostName;
        private System.Windows.Forms.Label labelTestPassword;
        private System.Windows.Forms.TextBox textBoxTestPassword;
        private System.Windows.Forms.Label labelTestUserName;
        private System.Windows.Forms.TextBox textBoxTestUserName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBoxConnectionDetails;
    }
}