using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// added
using Catfish.Models;
using System.Collections.ObjectModel;

namespace Catfish
{
    class Image
    {
        public string brief{ get; set; }
        public string imageUrl{ get; set; }
        public string username { get; set; }
        public string date { get; set; }
        public int commentsCount { get; set; }
        public int likesCount { get; set; }
        public ObservableCollection<Comment> commentsList = new ObservableCollection<Comment>();

        public Image(string brief, string imageUrl, string username, string date, int cc, int lc)
        {
            this.brief = brief;
            this.imageUrl = imageUrl;
            this.username = username;
            this.date = date;
            this.commentsCount = cc;
            this.likesCount = lc;

            setCommentsList();
        }

        /// <summary>
        /// 根据图片的ID在后台数据库中搜索出所有评论存进commentsList中
        /// </summary>
        private void setCommentsList()
        { 
            //test
            commentsList.Add(new Comment("1", "great!", "angelababy", "today"));
            commentsList.Add(new Comment("1", "=-=", "boy", "today"));
            commentsList.Add(new Comment("1", "OMGgggg", "cocorocha", "today"));
            commentsList.Add(new Comment("1", "i luv it~!!!", "xiaoxin", "today"));
        }
    }
}
