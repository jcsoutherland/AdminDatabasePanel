
namespace DatabaseFinal
{
    partial class CustomQForm
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
            this.QueryText = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.SendQueryBtn = new System.Windows.Forms.Button();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.NewQBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QueryText
            // 
            this.QueryText.Location = new System.Drawing.Point(10, 29);
            this.QueryText.Multiline = true;
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(439, 342);
            this.QueryText.TabIndex = 0;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(66, 13);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Enter Query:";
            // 
            // SendQueryBtn
            // 
            this.SendQueryBtn.Location = new System.Drawing.Point(10, 377);
            this.SendQueryBtn.Name = "SendQueryBtn";
            this.SendQueryBtn.Size = new System.Drawing.Size(219, 23);
            this.SendQueryBtn.TabIndex = 2;
            this.SendQueryBtn.Text = "Send Query";
            this.SendQueryBtn.UseVisualStyleBackColor = true;
            this.SendQueryBtn.Click += new System.EventHandler(this.SendQueryBtn_Click);
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.HorizontalScrollbar = true;
            this.ResultListBox.Location = new System.Drawing.Point(10, 29);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(439, 342);
            this.ResultListBox.TabIndex = 3;
            this.ResultListBox.Visible = false;
            // 
            // NewQBtn
            // 
            this.NewQBtn.Location = new System.Drawing.Point(230, 377);
            this.NewQBtn.Name = "NewQBtn";
            this.NewQBtn.Size = new System.Drawing.Size(219, 23);
            this.NewQBtn.TabIndex = 4;
            this.NewQBtn.Text = "New Query";
            this.NewQBtn.UseVisualStyleBackColor = true;
            this.NewQBtn.Click += new System.EventHandler(this.NewQBtn_Click);
            // 
            // CustomQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 407);
            this.Controls.Add(this.NewQBtn);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.SendQueryBtn);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.QueryText);
            this.Name = "CustomQForm";
            this.Text = "CustomQForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryText;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Button SendQueryBtn;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.Button NewQBtn;
    }
}