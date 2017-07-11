namespace ChatMessenger.View
{
    partial class AddNewContactPrompt
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
            this.generalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.contactInfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.generalTableLayoutPanel.SuspendLayout();
            this.buttonBarTableLayoutPanel.SuspendLayout();
            this.contactInfoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalTableLayoutPanel
            // 
            this.generalTableLayoutPanel.AutoSize = true;
            this.generalTableLayoutPanel.ColumnCount = 1;
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.generalTableLayoutPanel.Controls.Add(this.buttonBarTableLayoutPanel, 0, 1);
            this.generalTableLayoutPanel.Controls.Add(this.contactInfoTableLayoutPanel, 0, 0);
            this.generalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.generalTableLayoutPanel.Name = "generalTableLayoutPanel";
            this.generalTableLayoutPanel.RowCount = 2;
            this.generalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.generalTableLayoutPanel.Size = new System.Drawing.Size(319, 55);
            this.generalTableLayoutPanel.TabIndex = 0;
            // 
            // buttonBarTableLayoutPanel
            // 
            this.buttonBarTableLayoutPanel.AutoSize = true;
            this.buttonBarTableLayoutPanel.ColumnCount = 3;
            this.buttonBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonBarTableLayoutPanel.Controls.Add(this.okButton, 1, 0);
            this.buttonBarTableLayoutPanel.Controls.Add(this.cancelButton, 2, 0);
            this.buttonBarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBarTableLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.buttonBarTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBarTableLayoutPanel.Name = "buttonBarTableLayoutPanel";
            this.buttonBarTableLayoutPanel.RowCount = 1;
            this.buttonBarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonBarTableLayoutPanel.Size = new System.Drawing.Size(319, 29);
            this.buttonBarTableLayoutPanel.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.Location = new System.Drawing.Point(160, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(241, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // contactInfoTableLayoutPanel
            // 
            this.contactInfoTableLayoutPanel.AutoSize = true;
            this.contactInfoTableLayoutPanel.ColumnCount = 2;
            this.contactInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contactInfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contactInfoTableLayoutPanel.Controls.Add(this.nameLabel, 0, 0);
            this.contactInfoTableLayoutPanel.Controls.Add(this.usernameTextBox, 1, 0);
            this.contactInfoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactInfoTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.contactInfoTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contactInfoTableLayoutPanel.Name = "contactInfoTableLayoutPanel";
            this.contactInfoTableLayoutPanel.RowCount = 1;
            this.contactInfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contactInfoTableLayoutPanel.Size = new System.Drawing.Size(319, 26);
            this.contactInfoTableLayoutPanel.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(153, 26);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Username:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.Location = new System.Drawing.Point(162, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(154, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // AddNewContactPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 55);
            this.Controls.Add(this.generalTableLayoutPanel);
            this.Name = "AddNewContactPrompt";
            this.Text = "Add New Contact";
            this.generalTableLayoutPanel.ResumeLayout(false);
            this.generalTableLayoutPanel.PerformLayout();
            this.buttonBarTableLayoutPanel.ResumeLayout(false);
            this.buttonBarTableLayoutPanel.PerformLayout();
            this.contactInfoTableLayoutPanel.ResumeLayout(false);
            this.contactInfoTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel generalTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonBarTableLayoutPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel contactInfoTableLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}