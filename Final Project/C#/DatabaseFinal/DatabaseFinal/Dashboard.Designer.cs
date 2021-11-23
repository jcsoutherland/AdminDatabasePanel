
namespace DatabaseFinal
{
    partial class Dashboard
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
            this.DisplayInfoBox = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.EnterTableLabel = new System.Windows.Forms.Label();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayInfoBox
            // 
            this.DisplayInfoBox.FormattingEnabled = true;
            this.DisplayInfoBox.Location = new System.Drawing.Point(12, 80);
            this.DisplayInfoBox.Name = "DisplayInfoBox";
            this.DisplayInfoBox.Size = new System.Drawing.Size(359, 264);
            this.DisplayInfoBox.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(243, 43);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 21);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(99, 43);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(138, 20);
            this.SearchTxtBox.TabIndex = 2;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(25, 12);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 21);
            this.ConnectBtn.TabIndex = 3;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // EnterTableLabel
            // 
            this.EnterTableLabel.AutoSize = true;
            this.EnterTableLabel.Location = new System.Drawing.Point(22, 46);
            this.EnterTableLabel.Name = "EnterTableLabel";
            this.EnterTableLabel.Size = new System.Drawing.Size(65, 13);
            this.EnterTableLabel.TabIndex = 4;
            this.EnterTableLabel.Text = "Enter Table:";
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ConnectionLabel.Location = new System.Drawing.Point(106, 16);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(79, 13);
            this.ConnectionLabel.TabIndex = 5;
            this.ConnectionLabel.Text = "Not Connected";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 360);
            this.Controls.Add(this.ConnectionLabel);
            this.Controls.Add(this.EnterTableLabel);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DisplayInfoBox);
            this.Name = "Dashboard";
            this.Text = "Database Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayInfoBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label EnterTableLabel;
        private System.Windows.Forms.Label ConnectionLabel;
    }
}

