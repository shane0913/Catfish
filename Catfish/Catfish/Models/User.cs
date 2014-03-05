using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catfish
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public string gender { get; set; }
        public string brief { get; set; }
        public string createdDate { get; set; }
        public string imageIcon { get; set; }

        public User(string username,string password, string nickname, string gender,
            string brief, string createdDate, string imageIcon)
        {
            this.username = username;
            this.password = password;
            this.nickname = nickname;
            this.gender = gender;
            this.brief = brief;
            this.createdDate = createdDate;
            this.imageIcon = imageIcon;
        }

    }
}
