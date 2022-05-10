using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class Comment:BaseEntity
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string CommentContent { get; set; }

        public virtual User User { get; set; }

    }
}
