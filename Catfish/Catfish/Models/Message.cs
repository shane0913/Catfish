using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catfish.Models
{
    class Message
    {
        public string poster { get; set; }
        public string type { get; set; }
        public string sender { get; set; }
        public string senderIcon { get; set; }
        public string content { get; set; }
        public string time { get; set; }
        public string imageUrl { get; set; }

        public Message(string poster,string type, string sender,string senderIcon,
            string content, string time, string imageUrl) 
        {
            this.poster = poster;
            this.type = type;
            this.sender = sender;
            this.senderIcon = senderIcon;
            this.content = content;
            this.time = time;
            this.imageUrl = imageUrl;
        }
    }
}
