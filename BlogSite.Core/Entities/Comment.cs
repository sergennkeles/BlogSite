using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class Comment:BaseEntity
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public virtual Post Post { get; set; }
        public virtual List<User> Users { get; set; }
        public string CommentContent { get; set; }
      //public virtual List<Comment> Comments { get; set; }

    }
}
