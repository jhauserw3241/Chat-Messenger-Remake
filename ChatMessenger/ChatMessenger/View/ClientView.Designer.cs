namespace ChatMessenger
{
    partial class ClientView
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
            this.components = new System.ComponentModel.Container();
            this.bindingViewModel = new System.Windows.Forms.BindingSource(this.components);
            this.generalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainOptionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.contactsButton = new System.Windows.Forms.Button();
            this.conversationsButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingViewModel)).BeginInit();
            this.generalTableLayoutPanel.SuspendLayout();
            this.mainOptionsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalTableLayoutPanel
            // 
            this.generalTableLayoutPanel.ColumnCount = 2;
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.generalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalTableLayoutPanel.Controls.Add(this.mainOptionsTableLayoutPanel, 0, 0);
            this.generalTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.generalTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.generalTableLayoutPanel.Name = "generalTableLayoutPanel";
            this.generalTableLayoutPanel.RowCount = 1;
            this.generalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.generalTableLayoutPanel.Size = new System.Drawing.Size(517, 261);
            this.generalTableLayoutPanel.TabIndex = 0;
            // 
            // mainOptionsTableLayoutPanel
            // 
            this.mainOptionsTableLayoutPanel.ColumnCount = 1;
            this.mainOptionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainOptionsTableLayoutPanel.Controls.Add(this.homeButton, 0, 0);
            this.mainOptionsTableLayoutPanel.Controls.Add(this.contactsButton, 0, 1);
            this.mainOptionsTableLayoutPanel.Controls.Add(this.conversationsButton, 0, 2);
            this.mainOptionsTableLayoutPanel.Controls.Add(this.settingsButton, 0, 3);
            this.mainOptionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainOptionsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainOptionsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainOptionsTableLayoutPanel.Name = "mainOptionsTableLayoutPanel";
            this.mainOptionsTableLayoutPanel.RowCount = 4;
            this.mainOptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainOptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainOptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainOptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainOptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainOptionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainOptionsTableLayoutPanel.Size = new System.Drawing.Size(100, 261);
            this.mainOptionsTableLayoutPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.AutoSize = true;
            this.homeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(94, 59);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // contactsButton
            // 
            this.contactsButton.AutoSize = true;
            this.contactsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contactsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsButton.Location = new System.Drawing.Point(3, 68);
            this.contactsButton.Name = "contactsButton";
            this.contactsButton.Size = new System.Drawing.Size(94, 59);
            this.contactsButton.TabIndex = 2;
            this.contactsButton.Text = "Contacts";
            this.contactsButton.UseVisualStyleBackColor = true;
            this.contactsButton.Click += new System.EventHandler(this.contactsButton_Click);
            // 
            // conversationsButton
            // 
            this.conversationsButton.AutoSize = true;
            this.conversationsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conversationsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conversationsButton.Location = new System.Drawing.Point(3, 133);
            this.conversationsButton.Name = "conversationsButton";
            this.conversationsButton.Size = new System.Drawing.Size(94, 59);
            this.conversationsButton.TabIndex = 3;
            this.conversationsButton.Text = "Conversations";
            this.conversationsButton.UseVisualStyleBackColor = true;
            this.conversationsButton.Click += new System.EventHandler(this.conversationsButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSize = true;
            this.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsButton.Location = new System.Drawing.Point(3, 198);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(94, 60);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 261);
            this.Controls.Add(this.generalTableLayoutPanel);
            this.Name = "ClientView";
            this.Text = "Messenger";
            ((System.ComponentModel.ISupportInitialize)(this.bindingViewModel)).EndInit();
            this.generalTableLayoutPanel.ResumeLayout(false);
            this.mainOptionsTableLayoutPanel.ResumeLayout(false);
            this.mainOptionsTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingViewModel;
        private System.Windows.Forms.TableLayoutPanel generalTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel mainOptionsTableLayoutPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button contactsButton;
        private System.Windows.Forms.Button conversationsButton;
        private System.Windows.Forms.Button settingsButton;
    }
}

