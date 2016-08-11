using ChatMessenger.View;
using System;
using System.Windows.Forms;

namespace ChatMessenger
{
    public partial class ClientView : Form, IClientView
    {
        public event EventHandler HomeButtonClicked;
        public event EventHandler ContactsButtonClicked;
        public event EventHandler ConversationsButtonClicked;
        public event EventHandler SettingsButtonClicked;

        public ClientView()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeButtonClicked?.Invoke(this, new EventArgs());
        }

        private void contactsButton_Click(object sender, EventArgs e)
        {
            ContactsButtonClicked?.Invoke(this, new EventArgs());
        }

        private void conversationsButton_Click(object sender, EventArgs e)
        {
            ConversationsButtonClicked?.Invoke(this, new EventArgs());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsButtonClicked?.Invoke(this, new EventArgs());
        }
    }
}
