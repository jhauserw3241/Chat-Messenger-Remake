using System;

namespace ChatMessenger.View
{
    public interface IClientView
    {
        event EventHandler HomeButtonClicked;
        event EventHandler ContactsButtonClicked;
        event EventHandler ConversationsButtonClicked;
        event EventHandler SettingsButtonClicked;
    }
}
