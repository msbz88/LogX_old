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
            this.menuStripLogX = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxLogs = new System.Windows.Forms.CheckBox();
            this.checkBoxCompare = new System.Windows.Forms.CheckBox();
            this.checkBoxRuntime = new System.Windows.Forms.CheckBox();
            this.labelBJGNames = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelMessages = new System.Windows.Forms.Label();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.menuStripLogX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(175, 165);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecuteClick);
            // 
            // menuStripLogX
            // 
            this.menuStripLogX.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStripLogX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuDatabase,
            this.ToolStripMenuAbout});
            this.menuStripLogX.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStripLogX.Location = new System.Drawing.Point(0, 0);
            this.menuStripLogX.Name = "menuStripLogX";
            this.menuStripLogX.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripLogX.Size = new System.Drawing.Size(414, 24);
            this.menuStripLogX.TabIndex = 2;
            // 
            // ToolStripMenuDatabase
            // 
            this.ToolStripMenuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemConnection});
            this.ToolStripMenuDatabase.Name = "ToolStripMenuDatabase";
            this.ToolStripMenuDatabase.Size = new System.Drawing.Size(67, 20);
            this.ToolStripMenuDatabase.Text = "Database";
            // 
            // ToolStripMenuItemConnection
            // 
            this.ToolStripMenuItemConnection.Name = "ToolStripMenuItemConnection";
            this.ToolStripMenuItemConnection.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItemConnection.Text = "Connection";
            this.ToolStripMenuItemConnection.Click += new System.EventHandler(this.ToolStripMenuItemConnectionClick);
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
            this.ToolStripMenuItemVersion.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItemVersion.Text = "Version";
            this.ToolStripMenuItemVersion.Click += new System.EventHandler(this.ToolStripMenuItemVersionClick);
            // 
            // checkBoxLogs
            // 
            this.checkBoxLogs.AutoSize = true;
            this.checkBoxLogs.Location = new System.Drawing.Point(175, 55);
            this.checkBoxLogs.Name = "checkBoxLogs";
            this.checkBoxLogs.Size = new System.Drawing.Size(169, 17);
            this.checkBoxLogs.TabIndex = 3;
            this.checkBoxLogs.Text = "Extract Batch Job Groups logs";
            this.checkBoxLogs.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompare
            // 
            this.checkBoxCompare.AutoSize = true;
            this.checkBoxCompare.Location = new System.Drawing.Point(175, 78);
            this.checkBoxCompare.Name = "checkBoxCompare";
            this.checkBoxCompare.Size = new System.Drawing.Size(137, 17);
            this.checkBoxCompare.TabIndex = 4;
            this.checkBoxCompare.Text = "Compare extracted logs";
            this.checkBoxCompare.UseVisualStyleBackColor = true;
            // 
            // checkBoxRuntime
            // 
            this.checkBoxRuntime.AutoSize = true;
            this.checkBoxRuntime.Location = new System.Drawing.Point(175, 101);
            this.checkBoxRuntime.Name = "checkBoxRuntime";
            this.checkBoxRuntime.Size = new System.Drawing.Size(239, 17);
            this.checkBoxRuntime.TabIndex = 5;
            this.checkBoxRuntime.Text = "Generate BJG Run Time Measurement report";
            this.checkBoxRuntime.UseVisualStyleBackColor = true;
            // 
            // labelBJGNames
            // 
            this.labelBJGNames.AutoSize = true;
            this.labelBJGNames.Location = new System.Drawing.Point(9, 39);
            this.labelBJGNames.Name = "labelBJGNames";
            this.labelBJGNames.Size = new System.Drawing.Size(70, 13);
            this.labelBJGNames.TabIndex = 8;
            this.labelBJGNames.Text = "BJG name(s):";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(296, 152);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(94, 13);
            this.labelStartDate.TabIndex = 10;
            this.labelStartDate.Text = "Progect start date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(157, 353);
            this.dataGridView1.TabIndex = 12;
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Location = new System.Drawing.Point(12, 410);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(0, 13);
            this.labelMessages.TabIndex = 20;
            // 
            // listViewMessages
            // 
            this.listViewMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewMessages.Location = new System.Drawing.Point(175, 194);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(228, 214);
            this.listViewMessages.TabIndex = 21;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.Tile;
            // 
            // FormLogX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(414, 428);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelBJGNames);
            this.Controls.Add(this.checkBoxRuntime);
            this.Controls.Add(this.checkBoxCompare);
            this.Controls.Add(this.checkBoxLogs);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.MenuStrip menuStripLogX;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuDatabase;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnection;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVersion;
        private System.Windows.Forms.CheckBox checkBoxLogs;
        private System.Windows.Forms.CheckBox checkBoxCompare;
        private System.Windows.Forms.CheckBox checkBoxRuntime;
        private System.Windows.Forms.Label labelBJGNames;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.ListView listViewMessages;
    }
}

