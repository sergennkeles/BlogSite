using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class Comment:BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public string CommentContent { get; set; }
        
    }
}
