
namespace DatabaseFinal
{
    partial class UpdateForm
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
            this.ColumnLabel = new System.Windows.Forms.Label();
            this.UpdateTxt = new System.Windows.Forms.TextBox();
            this.WhereLabel = new System.Windows.Forms.Label();
            this.WhereTxt = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ColumnDescriptorTxt = new System.Windows.Forms.Label();
            this.TypeDescriptorTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColumnLabel
            // 
            this.ColumnLabel.AutoSize = true;
            this.ColumnLabel.Location = new System.Drawing.Point(13, 13);
            this.ColumnLabel.Name = "ColumnLabel";
            this.ColumnLabel.Size = new System.Drawing.Size(364, 13);
            this.ColumnLabel.TabIndex = 0;
            this.ColumnLabel.Text = "Enter \"ColumnName=NewValue\" (Multiple Columns Seperated By Commas):";
            // 
            // UpdateTxt
            // 
            this.UpdateTxt.Location = new System.Drawing.Point(13, 30);
            this.UpdateTxt.Name = "UpdateTxt";
            this.UpdateTxt.Size = new System.Drawing.Size(399, 20);
            this.UpdateTxt.TabIndex = 1;
            // 
            // WhereLabel
            // 
            this.WhereLabel.AutoSize = true;
            this.WhereLabel.Location = new System.Drawing.Point(10, 82);
            this.WhereLabel.Name = "WhereLabel";
            this.WhereLabel.Size = new System.Drawing.Size(293, 13);
            this.WhereLabel.TabIndex = 2;
            this.WhereLabel.Text = "Enter \"Where Column=Value\" or Leave Blank For All Values:";
            // 
            // WhereTxt
            // 
            this.WhereTxt.Location = new System.Drawing.Point(12, 98);
            this.WhereTxt.Name = "WhereTxt";
            this.WhereTxt.Size = new System.Drawing.Size(399, 20);
            this.WhereTxt.TabIndex = 3;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(148, 149);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(131, 23);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ColumnDescriptorTxt
            // 
            this.ColumnDescriptorTxt.AutoSize = true;
            this.ColumnDescriptorTxt.Location = new System.Drawing.Point(13, 53);
            this.ColumnDescriptorTxt.Name = "ColumnDescriptorTxt";
            this.ColumnDescriptorTxt.Size = new System.Drawing.Size(53, 13);
            this.ColumnDescriptorTxt.TabIndex = 5;
            this.ColumnDescriptorTxt.Text = "Columns: ";
            // 
            // TypeDescriptorTxt
            // 
            this.TypeDescriptorTxt.AutoSize = true;
            this.TypeDescriptorTxt.Location = new System.Drawing.Point(13, 122);
            this.TypeDescriptorTxt.Name = "TypeDescriptorTxt";
            this.TypeDescriptorTxt.Size = new System.Drawing.Size(42, 13);
            this.TypeDescriptorTxt.TabIndex = 6;
            this.TypeDescriptorTxt.Text = "Types: ";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 181);
            this.Controls.Add(this.TypeDescriptorTxt);
            this.Controls.Add(this.ColumnDescriptorTxt);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.WhereTxt);
            this.Controls.Add(this.WhereLabel);
            this.Controls.Add(this.UpdateTxt);
            this.Controls.Add(this.ColumnLabel);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ColumnLabel;
        private System.Windows.Forms.TextBox UpdateTxt;
        private System.Windows.Forms.Label WhereLabel;
        private System.Windows.Forms.TextBox WhereTxt;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label ColumnDescriptorTxt;
        private System.Windows.Forms.Label TypeDescriptorTxt;
    }
}