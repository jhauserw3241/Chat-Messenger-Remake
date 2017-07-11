using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger
{
    public class Conversation
    {
        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        public string Name
        {
            get { return _name; }
        }

        public IList<Contact> Participants
        {
            get { return _participants; }
        }

        public Conversation(string name)
        {
            _name = name;
            _displayName = name;
            _participants = new List<Contact>();
        }

        private string _displayName;
        private readonly string _name;
        private readonly IList<Contact> _participants;
    }
}
