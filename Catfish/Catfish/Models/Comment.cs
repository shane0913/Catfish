using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catfish.Models
{
    class Comment
    {
        public string imageId { get; set; }
        public string content { get; set; }
        public string username { get; set; }
        public string date { get; set; }

        public Comment(string imageId, string content, string username, string date) 
        {
            this.imageId = imageId;
            this.content = content;
            this.username = username;
            this.date = date;
        }
    }
}
