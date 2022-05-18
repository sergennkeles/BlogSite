using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Dtos
{
    public class CommentDto:BaseDto
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string CommentContent { get; set; }
    }
}
