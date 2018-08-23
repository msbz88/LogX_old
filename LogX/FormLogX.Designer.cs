namespace LogX {
    partial class FormLogX {
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
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxMessages = new System.Windows.Forms.TextBox();
            this.menuStripLogX = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxLogs = new System.Windows.Forms.CheckBox();
            this.checkBoxCompare = new System.Windows.Forms.CheckBox();
            this.checkBoxRuntime = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelBJGNames = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxBJGNames = new System.Windows.Forms.RichTextBox();
            this.menuStripLogX.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(7, 196);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecuteClick);
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessages.Location = new System.Drawing.Point(7, 414);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(401, 13);
            this.textBoxMessages.TabIndex = 1;
            this.textBoxMessages.TabStop = false;
            // 
            // menuStripLogX
            // 
            this.menuStripLogX.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStripLogX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuConnection,
            this.ToolStripMenuAbout});
            this.menuStripLogX.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripLogX.Location = new System.Drawing.Point(0, 0);
            this.menuStripLogX.Name = "menuStripLogX";
            this.menuStripLogX.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripLogX.Size = new System.Drawing.Size(414, 24);
            this.menuStripLogX.TabIndex = 2;
            // 
            // ToolStripMenuConnection
            // 
            this.ToolStripMenuConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDatabase});
            this.ToolStripMenuConnection.Name = "ToolStripMenuConnection";
            this.ToolStripMenuConnection.Size = new System.Drawing.Size(74, 20);
            this.ToolStripMenuConnection.Text = "Conection";
            // 
            // ToolStripMenuItemDatabase
            // 
            this.ToolStripMenuItemDatabase.Name = "ToolStripMenuItemDatabase";
            this.ToolStripMenuItemDatabase.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemDatabase.Text = "Database";
            this.ToolStripMenuItemDatabase.Click += new System.EventHandler(this.ToolStripMenuItemDatabaseClick);
            // 
            // ToolStripMenuAbout
            // 
            this.ToolStripMenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVersion});
            this.ToolStripMenuAbout.Name = "ToolStripMenuAbout";
            this.ToolStripMenuAbout.Size = new System.Drawing.Size(52, 20);
            this.ToolStripMenuAbout.Text = "About";
            // 
            // ToolStripMenuItemVersion
            // 
            this.ToolStripMenuItemVersion.Name = "ToolStripMenuItemVersion";
            this.ToolStripMenuItemVersion.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemVersion.Text = "Version";
            this.ToolStripMenuItemVersion.Click += new System.EventHandler(this.ToolStripMenuItemVersionClick);
            // 
            // checkBoxLogs
            // 
            this.checkBoxLogs.AutoSize = true;
            this.checkBoxLogs.Location = new System.Drawing.Point(7, 60);
            this.checkBoxLogs.Name = "checkBoxLogs";
            this.checkBoxLogs.Size = new System.Drawing.Size(169, 17);
            this.checkBoxLogs.TabIndex = 3;
            this.checkBoxLogs.Text = "Extract Batch Job Groups logs";
            this.checkBoxLogs.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompare
            // 
            this.checkBoxCompare.AutoSize = true;
            this.checkBoxCompare.Location = new System.Drawing.Point(7, 83);
            this.checkBoxCompare.Name = "checkBoxCompare";
            this.checkBoxCompare.Size = new System.Drawing.Size(137, 17);
            this.checkBoxCompare.TabIndex = 4;
            this.checkBoxCompare.Text = "Compare extracted logs";
            this.checkBoxCompare.UseVisualStyleBackColor = true;
            // 
            // checkBoxRuntime
            // 
            this.checkBoxRuntime.AutoSize = true;
            this.checkBoxRuntime.Location = new System.Drawing.Point(7, 106);
            this.checkBoxRuntime.Name = "checkBoxRuntime";
            this.checkBoxRuntime.Size = new System.Drawing.Size(239, 17);
            this.checkBoxRuntime.TabIndex = 5;
            this.checkBoxRuntime.Text = "Generate BJG Run Time Measurement report";
            this.checkBoxRuntime.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(7, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(401, 180);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // labelBJGNames
            // 
            this.labelBJGNames.AutoSize = true;
            this.labelBJGNames.Location = new System.Drawing.Point(256, 44);
            this.labelBJGNames.Name = "labelBJGNames";
            this.labelBJGNames.Size = new System.Drawing.Size(70, 13);
            this.labelBJGNames.TabIndex = 8;
            this.labelBJGNames.Text = "BJG name(s):";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(4, 145);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(94, 13);
            this.labelStartDate.TabIndex = 10;
            this.labelStartDate.Text = "Progect start date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // richTextBoxBJGNames
            // 
            this.richTextBoxBJGNames.Location = new System.Drawing.Point(259, 60);
            this.richTextBoxBJGNames.Name = "richTextBoxBJGNames";
            this.richTextBoxBJGNames.Size = new System.Drawing.Size(149, 170);
            this.richTextBoxBJGNames.TabIndex = 12;
            this.richTextBoxBJGNames.Text = "";
            // 
            // FormLogX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 428);
            this.Controls.Add(this.richTextBoxBJGNames);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelBJGNames);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBoxRuntime);
            this.Controls.Add(this.checkBoxCompare);
            this.Controls.Add(this.checkBoxLogs);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.menuStripLogX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripLogX;
            this.MaximizeBox = false;
            this.Name = "FormLogX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogX";
            this.menuStripLogX.ResumeLayout(false);
            this.menuStripLogX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxMessages;
        private System.Windows.Forms.MenuStrip menuStripLogX;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuConnection;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDatabase;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVersion;
        private System.Windows.Forms.CheckBox checkBoxLogs;
        private System.Windows.Forms.CheckBox checkBoxCompare;
        private System.Windows.Forms.CheckBox checkBoxRuntime;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelBJGNames;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBoxBJGNames;
    }
}

