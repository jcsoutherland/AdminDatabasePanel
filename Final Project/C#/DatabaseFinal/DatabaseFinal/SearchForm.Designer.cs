
namespace DatabaseFinal
{
    partial class SearchForm
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
            this.TableLabel = new System.Windows.Forms.Label();
            this.PropertyMenu = new System.Windows.Forms.ComboBox();
            this.DisplayInfoBox = new System.Windows.Forms.ListBox();
            this.KeyTextbox = new System.Windows.Forms.TextBox();
            this.KeywordLabel = new System.Windows.Forms.Label();
            this.GoBtn = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(13, 13);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(84, 13);
            this.TableLabel.TabIndex = 0;
            this.TableLabel.Text = "Choose Column:";
            // 
            // PropertyMenu
            // 
            this.PropertyMenu.FormattingEnabled = true;
            this.PropertyMenu.Location = new System.Drawing.Point(16, 29);
            this.PropertyMenu.Name = "PropertyMenu";
            this.PropertyMenu.Size = new System.Drawing.Size(121, 21);
            this.PropertyMenu.TabIndex = 1;
            // 
            // DisplayInfoBox
            // 
            this.DisplayInfoBox.FormattingEnabled = true;
            this.DisplayInfoBox.Location = new System.Drawing.Point(16, 56);
            this.DisplayInfoBox.Name = "DisplayInfoBox";
            this.DisplayInfoBox.Size = new System.Drawing.Size(492, 199);
            this.DisplayInfoBox.TabIndex = 2;
            // 
            // KeyTextbox
            // 
            this.KeyTextbox.Location = new System.Drawing.Point(144, 29);
            this.KeyTextbox.Name = "KeyTextbox";
            this.KeyTextbox.Size = new System.Drawing.Size(160, 20);
            this.KeyTextbox.TabIndex = 3;
            // 
            // KeywordLabel
            // 
            this.KeywordLabel.AutoSize = true;
            this.KeywordLabel.Location = new System.Drawing.Point(143, 13);
            this.KeywordLabel.Name = "KeywordLabel";
            this.KeywordLabel.Size = new System.Drawing.Size(92, 13);
            this.KeywordLabel.TabIndex = 4;
            this.KeywordLabel.Text = "Type Search Key:";
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(310, 29);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(47, 20);
            this.GoBtn.TabIndex = 5;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(356, 9);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(156, 39);
            this.NoteLabel.TabIndex = 6;
            this.NoteLabel.Text = "ex: |\"= 2010\"                            |\r\n      |\"Like \'%Theater%\'\"            " +
    "|\r\n      |\"Between 2010 and 2012\"|";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 264);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.KeywordLabel);
            this.Controls.Add(this.KeyTextbox);
            this.Controls.Add(this.DisplayInfoBox);
            this.Controls.Add(this.PropertyMenu);
            this.Controls.Add(this.TableLabel);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox PropertyMenu;
        private System.Windows.Forms.ListBox DisplayInfoBox;
        private System.Windows.Forms.TextBox KeyTextbox;
        private System.Windows.Forms.Label KeywordLabel;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Label NoteLabel;
    }
}