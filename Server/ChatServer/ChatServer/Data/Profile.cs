using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.ViewModel
{
    public class Profile : Person
    {
        public DateTime CreatedOn { get; set; }

        public override string ToJson()
        {
            return "{ Username: " + Username + ", Id: " + Id + ", CreatedOn: " + CreatedOn + " }";
        }
    }
}
