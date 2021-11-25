
namespace DatabaseFinal
{
    partial class InsertForm
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
            this.EnterColumnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnsText = new System.Windows.Forms.TextBox();
            this.ValuesText = new System.Windows.Forms.TextBox();
            this.InsrtButton = new System.Windows.Forms.Button();
            this.ColumnNamesTxt = new System.Windows.Forms.Label();
            this.ColumnTypesTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterColumnLabel
            // 
            this.EnterColumnLabel.AutoSize = true;
            this.EnterColumnLabel.Location = new System.Drawing.Point(13, 13);
            this.EnterColumnLabel.Name = "EnterColumnLabel";
            this.EnterColumnLabel.Size = new System.Drawing.Size(204, 13);
            this.EnterColumnLabel.TabIndex = 0;
            this.EnterColumnLabel.Text = "Enter Columns To Insert Split By Commas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Values To Insert Split By Commas:";
            // 
            // ColumnsText
            // 
            this.ColumnsText.Location = new System.Drawing.Point(16, 30);
            this.ColumnsText.Name = "ColumnsText";
            this.ColumnsText.Size = new System.Drawing.Size(367, 20);
            this.ColumnsText.TabIndex = 2;
            // 
            // ValuesText
            // 
            this.ValuesText.Location = new System.Drawing.Point(16, 112);
            this.ValuesText.Name = "ValuesText";
            this.ValuesText.Size = new System.Drawing.Size(367, 20);
            this.ValuesText.TabIndex = 3;
            // 
            // InsrtButton
            // 
            this.InsrtButton.Location = new System.Drawing.Point(144, 159);
            this.InsrtButton.Name = "InsrtButton";
            this.InsrtButton.Size = new System.Drawing.Size(117, 23);
            this.InsrtButton.TabIndex = 4;
            this.InsrtButton.Text = "Insert";
            this.InsrtButton.UseVisualStyleBackColor = true;
            this.InsrtButton.Click += new System.EventHandler(this.InsrtButton_Click);
            // 
            // ColumnNamesTxt
            // 
            this.ColumnNamesTxt.AutoSize = true;
            this.ColumnNamesTxt.Location = new System.Drawing.Point(13, 53);
            this.ColumnNamesTxt.Name = "ColumnNamesTxt";
            this.ColumnNamesTxt.Size = new System.Drawing.Size(84, 13);
            this.ColumnNamesTxt.TabIndex = 5;
            this.ColumnNamesTxt.Text = "Column Names: ";
            // 
            // ColumnTypesTxt
            // 
            this.ColumnTypesTxt.AutoSize = true;
            this.ColumnTypesTxt.Location = new System.Drawing.Point(13, 135);
            this.ColumnTypesTxt.Name = "ColumnTypesTxt";
            this.ColumnTypesTxt.Size = new System.Drawing.Size(77, 13);
            this.ColumnTypesTxt.TabIndex = 6;
            this.ColumnTypesTxt.Text = "Column Types:";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 194);
            this.Controls.Add(this.ColumnTypesTxt);
            this.Controls.Add(this.ColumnNamesTxt);
            this.Controls.Add(this.InsrtButton);
            this.Controls.Add(this.ValuesText);
            this.Controls.Add(this.ColumnsText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterColumnLabel);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterColumnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColumnsText;
        private System.Windows.Forms.TextBox ValuesText;
        private System.Windows.Forms.Button InsrtButton;
        private System.Windows.Forms.Label ColumnNamesTxt;
        private System.Windows.Forms.Label ColumnTypesTxt;
    }
}