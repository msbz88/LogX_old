namespace LogX {
    partial class FormExcludedBJG {
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
            this.listViewExcludedBJG = new System.Windows.Forms.ListView();
            this.textBoxExcludedBJG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewExcludedBJG
            // 
            this.listViewExcludedBJG.FullRowSelect = true;
            this.listViewExcludedBJG.GridLines = true;
            this.listViewExcludedBJG.Location = new System.Drawing.Point(8, 31);
            this.listViewExcludedBJG.Name = "listViewExcludedBJG";
            this.listViewExcludedBJG.Size = new System.Drawing.Size(580, 450);
            this.listViewExcludedBJG.TabIndex = 0;
            this.listViewExcludedBJG.UseCompatibleStateImageBehavior = false;
            this.listViewExcludedBJG.View = System.Windows.Forms.View.Details;
            // 
            // textBoxExcludedBJG
            // 
            this.textBoxExcludedBJG.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxExcludedBJG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExcludedBJG.Location = new System.Drawing.Point(8, 11);
            this.textBoxExcludedBJG.Name = "textBoxExcludedBJG";
            this.textBoxExcludedBJG.ReadOnly = true;
            this.textBoxExcludedBJG.Size = new System.Drawing.Size(559, 13);
            this.textBoxExcludedBJG.TabIndex = 1;
            this.textBoxExcludedBJG.TabStop = false;
            // 
            // FormExcludedBJG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(595, 492);
            this.Controls.Add(this.textBoxExcludedBJG);
            this.Controls.Add(this.listViewExcludedBJG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExcludedBJG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluded Batch Job Groups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewExcludedBJG;
        private System.Windows.Forms.TextBox textBoxExcludedBJG;
    }
}