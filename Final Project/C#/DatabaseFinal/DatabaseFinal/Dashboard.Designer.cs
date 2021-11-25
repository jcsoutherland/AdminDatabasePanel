
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.EnterTableLabel = new System.Windows.Forms.Label();
            this.ConnectionLabel = new System.Windows.Forms.Label();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CustomBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Enabled = false;
            this.SearchBtn.Location = new System.Drawing.Point(25, 59);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 21);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(25, 5);
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
            this.EnterTableLabel.Location = new System.Drawing.Point(21, 35);
            this.EnterTableLabel.Name = "EnterTableLabel";
            this.EnterTableLabel.Size = new System.Drawing.Size(70, 13);
            this.EnterTableLabel.TabIndex = 4;
            this.EnterTableLabel.Text = "Select Table:";
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ConnectionLabel.Location = new System.Drawing.Point(106, 9);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(79, 13);
            this.ConnectionLabel.TabIndex = 5;
            this.ConnectionLabel.Text = "Not Connected";
            // 
            // TableComboBox
            // 
            this.TableComboBox.Enabled = false;
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Items.AddRange(new object[] {
            "Theater",
            "Staff",
            "Movies",
            "Showing",
            "Tickets"});
            this.TableComboBox.Location = new System.Drawing.Point(97, 32);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(138, 21);
            this.TableComboBox.TabIndex = 6;
            // 
            // InsertBtn
            // 
            this.InsertBtn.Enabled = false;
            this.InsertBtn.Location = new System.Drawing.Point(106, 59);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 21);
            this.InsertBtn.TabIndex = 7;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.Location = new System.Drawing.Point(187, 59);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 21);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Enabled = false;
            this.DeleteBtn.Location = new System.Drawing.Point(268, 59);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 21);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete/Recover";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CustomBtn
            // 
            this.CustomBtn.Enabled = false;
            this.CustomBtn.Location = new System.Drawing.Point(24, 86);
            this.CustomBtn.Name = "CustomBtn";
            this.CustomBtn.Size = new System.Drawing.Size(338, 21);
            this.CustomBtn.TabIndex = 10;
            this.CustomBtn.Text = "Custom Query";
            this.CustomBtn.UseVisualStyleBackColor = true;
            this.CustomBtn.Click += new System.EventHandler(this.CustomBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 117);
            this.Controls.Add(this.CustomBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.ConnectionLabel);
            this.Controls.Add(this.EnterTableLabel);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.SearchBtn);
            this.Name = "Dashboard";
            this.Text = "Database Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label EnterTableLabel;
        private System.Windows.Forms.Label ConnectionLabel;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CustomBtn;
    }
}

