
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
            this.SuspendLayout();
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(12, 9);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(125, 13);
            this.DeleteLabel.TabIndex = 0;
            this.DeleteLabel.Text = "Enter \'Where\' Statement:";
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(16, 30);
            this.DeleteTextBox.Multiline = true;
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(366, 25);
            this.DeleteTextBox.TabIndex = 1;
            // 
            // DeleteFinalBtn
            // 
            this.DeleteFinalBtn.Location = new System.Drawing.Point(15, 61);
            this.DeleteFinalBtn.Name = "DeleteFinalBtn";
            this.DeleteFinalBtn.Size = new System.Drawing.Size(170, 23);
            this.DeleteFinalBtn.TabIndex = 2;
            this.DeleteFinalBtn.Text = "Delete";
            this.DeleteFinalBtn.UseVisualStyleBackColor = true;
            this.DeleteFinalBtn.Click += new System.EventHandler(this.DeleteFinalBtn_Click);
            // 
            // RecoverBtn
            // 
            this.RecoverBtn.Location = new System.Drawing.Point(212, 61);
            this.RecoverBtn.Name = "RecoverBtn";
            this.RecoverBtn.Size = new System.Drawing.Size(170, 23);
            this.RecoverBtn.TabIndex = 3;
            this.RecoverBtn.Text = "Recover";
            this.RecoverBtn.UseVisualStyleBackColor = true;
            this.RecoverBtn.Click += new System.EventHandler(this.RecoverBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 93);
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
    }
}