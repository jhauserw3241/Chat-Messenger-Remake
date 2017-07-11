using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer.Data
{
    public class Message
    {
        public long ConversationId { get; set; }
        public long SenderId { get; set; }
        public string SenderUsername { get; set; }
        public string Text { get; set; }

        public string ToJson()
        {
            return "{ ConversationId: " + ConversationId +
                ", SenderId: " + SenderId +
                ", SenderUsername: " + SenderUsername +
                ", Text: " + Text + " }";
        }
    }
}
