using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger
{
    public class Contact
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

        public Image Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Contact(string name)
        {
            _displayName = name;
            _name = name;
        }

        private string _displayName;
        private string _name;
        private Image _status;
    }
}
