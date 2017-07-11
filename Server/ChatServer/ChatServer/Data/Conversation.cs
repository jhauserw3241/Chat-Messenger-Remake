using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Data
{
    public class Conversation
    {
        public long OwnerId { get; set; }
        public IList<Person> Participants { get; set; }
        public IList<Message> Messages { get; set; }
        public DateTime CreatedOn { get; set; }

        public string ToJson()
        {
            var participants = string.Join(",", Participants.Select(p => p.ToJson()));
            var messages = string.Join(",", Messages.Select(m => m.ToJson()));

            return "{ OwnerId: " + OwnerId +
                ", Participants: " + participants +
                ", Messages: "+ messages +
                ", CreatedOn: " + CreatedOn + " }";
        }
    }
}
