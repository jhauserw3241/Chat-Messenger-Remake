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
            this.generalTableLayoutPanel.SuspendLayout();
            this.buttonBarTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalTableLayoutPanel
            // 
            this.generalTableLayoutPanel.ColumnCount = 1;
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.generalTableLayoutPanel.Controls.Add(this.buttonBarTableLayoutPanel, 0, 1);
            this.generalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.generalTableLayoutPanel.Name = "generalTableLayoutPanel";
            this.generalTableLayoutPanel.RowCount = 2;
            this.generalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.generalTableLayoutPanel.Size = new System.Drawing.Size(284, 261);
            this.generalTableLayoutPanel.TabIndex = 0;
            // 
            // buttonBarTableLayoutPanel
            // 
            this.buttonBarTableLayoutPanel.ColumnCount = 3;
            this.buttonBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonBarTableLayoutPanel.Controls.Add(this.okButton, 1, 0);
            this.buttonBarTableLayoutPanel.Controls.Add(this.cancelButton, 2, 0);
            this.buttonBarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBarTableLayoutPanel.Location = new System.Drawing.Point(0, 130);
            this.buttonBarTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBarTableLayoutPanel.Name = "buttonBarTableLayoutPanel";
            this.buttonBarTableLayoutPanel.RowCount = 1;
            this.buttonBarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonBarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonBarTableLayoutPanel.Size = new System.Drawing.Size(284, 131);
            this.buttonBarTableLayoutPanel.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(97, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(191, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddNewContactPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.generalTableLayoutPanel);
            this.Name = "AddNewContactPrompt";
            this.Text = "Add New Contact";
            this.generalTableLayoutPanel.ResumeLayout(false);
            this.buttonBarTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel generalTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonBarTableLayoutPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}