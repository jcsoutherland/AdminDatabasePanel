
namespace DatabaseFinal
{
    partial class DeleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteFinalBtn = new System.Windows.Forms.Button();
            this.RecoverBtn = new System.Windows.Forms.Button();
            this.NotRemovedListBox = new System.Windows.Forms.ListBox();
            this.RemovedListBox = new System.Windows.Forms.ListBox();
            this.activeLbl = new System.Windows.Forms.Label();
            this.DletedLbl = new System.Windows.Forms.Label();
            this.ColumnNamesTxt = new System.Windows.Forms.Label();
            this.ColumnTypesTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(16, 9);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(144, 13);
            this.DeleteLabel.TabIndex = 0;
            this.DeleteLabel.Text = "Enter \'ColumnName = Value\':";
            this.DeleteLabel.Click += new System.EventHandler(this.DeleteLabel_Click);
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(16, 30);
            this.DeleteTextBox.Multiline = true;
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(362, 25);
            this.DeleteTextBox.TabIndex = 1;
            // 
            // DeleteFinalBtn
            // 
            this.DeleteFinalBtn.Location = new System.Drawing.Point(12, 346);
            this.DeleteFinalBtn.Name = "DeleteFinalBtn";
            this.DeleteFinalBtn.Size = new System.Drawing.Size(170, 23);
            this.DeleteFinalBtn.TabIndex = 2;
            this.DeleteFinalBtn.Text = "Delete";
            this.DeleteFinalBtn.UseVisualStyleBackColor = true;
            this.DeleteFinalBtn.Click += new System.EventHandler(this.DeleteFinalBtn_Click);
            // 
            // RecoverBtn
            // 
            this.RecoverBtn.Location = new System.Drawing.Point(208, 346);
            this.RecoverBtn.Name = "RecoverBtn";
            this.RecoverBtn.Size = new System.Drawing.Size(170, 23);
            this.RecoverBtn.TabIndex = 3;
            this.RecoverBtn.Text = "Recover";
            this.RecoverBtn.UseVisualStyleBackColor = true;
            this.RecoverBtn.Click += new System.EventHandler(this.RecoverBtn_Click);
            // 
            // NotRemovedListBox
            // 
            this.NotRemovedListBox.FormattingEnabled = true;
            this.NotRemovedListBox.HorizontalScrollbar = true;
            this.NotRemovedListBox.Location = new System.Drawing.Point(16, 118);
            this.NotRemovedListBox.Name = "NotRemovedListBox";
            this.NotRemovedListBox.Size = new System.Drawing.Size(362, 95);
            this.NotRemovedListBox.TabIndex = 4;
            // 
            // RemovedListBox
            // 
            this.RemovedListBox.FormattingEnabled = true;
            this.RemovedListBox.HorizontalScrollbar = true;
            this.RemovedListBox.Location = new System.Drawing.Point(16, 232);
            this.RemovedListBox.Name = "RemovedListBox";
            this.RemovedListBox.Size = new System.Drawing.Size(362, 95);
            this.RemovedListBox.TabIndex = 5;
            // 
            // activeLbl
            // 
            this.activeLbl.AutoSize = true;
            this.activeLbl.Location = new System.Drawing.Point(16, 102);
            this.activeLbl.Name = "activeLbl";
            this.activeLbl.Size = new System.Drawing.Size(70, 13);
            this.activeLbl.TabIndex = 6;
            this.activeLbl.Text = "Active Rows:";
            // 
            // DletedLbl
            // 
            this.DletedLbl.AutoSize = true;
            this.DletedLbl.Location = new System.Drawing.Point(16, 216);
            this.DletedLbl.Name = "DletedLbl";
            this.DletedLbl.Size = new System.Drawing.Size(77, 13);
            this.DletedLbl.TabIndex = 7;
            this.DletedLbl.Text = "Deleted Rows:";
            // 
            // ColumnNamesTxt
            // 
            this.ColumnNamesTxt.AutoSize = true;
            this.ColumnNamesTxt.Location = new System.Drawing.Point(16, 58);
            this.ColumnNamesTxt.Name = "ColumnNamesTxt";
            this.ColumnNamesTxt.Size = new System.Drawing.Size(53, 13);
            this.ColumnNamesTxt.TabIndex = 8;
            this.ColumnNamesTxt.Text = "Columns: ";
            // 
            // ColumnTypesTxt
            // 
            this.ColumnTypesTxt.AutoSize = true;
            this.ColumnTypesTxt.Location = new System.Drawing.Point(16, 80);
            this.ColumnTypesTxt.Name = "ColumnTypesTxt";
            this.ColumnTypesTxt.Size = new System.Drawing.Size(42, 13);
            this.ColumnTypesTxt.TabIndex = 9;
            this.ColumnTypesTxt.Text = "Types: ";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 381);
            this.Controls.Add(this.ColumnTypesTxt);
            this.Controls.Add(this.ColumnNamesTxt);
            this.Controls.Add(this.DletedLbl);
            this.Controls.Add(this.activeLbl);
            this.Controls.Add(this.RemovedListBox);
            this.Controls.Add(this.NotRemovedListBox);
            this.Controls.Add(this.RecoverBtn);
            this.Controls.Add(this.DeleteFinalBtn);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.DeleteLabel);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.Button DeleteFinalBtn;
        private System.Windows.Forms.Button RecoverBtn;
        private System.Windows.Forms.ListBox NotRemovedListBox;
        private System.Windows.Forms.ListBox RemovedListBox;
        private System.Windows.Forms.Label activeLbl;
        private System.Windows.Forms.Label DletedLbl;
        private System.Windows.Forms.Label ColumnNamesTxt;
        private System.Windows.Forms.Label ColumnTypesTxt;
    }
}