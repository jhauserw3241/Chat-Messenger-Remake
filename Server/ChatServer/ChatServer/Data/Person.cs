using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Data
{
    public abstract class Person
    {
        public string Username { get; set; }
        public long Id { get; set; }

        public virtual string ToJson()
        {
            return "{ Username: " + Username + ", Id: " + Id + " }";
        }
    }
}
