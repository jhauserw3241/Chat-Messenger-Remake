using System.Collections.Generic;

namespace ChatMessenger
{
    public class ClientViewModel
    {
        public IList<Contact> Contacts
        {
            get { return _contacts; }
        }
        public IList<Conversation> Conversations
        {
            get { return _conversations; }
        }

        public ClientViewModel()
        {
            _contacts = new List<Contact>();
            _conversations = new List<Conversation>();
        }

        private readonly IList<Contact> _contacts;
        private readonly IList<Conversation> _conversations;
    }
}
