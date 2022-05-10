using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class Post:BaseEntity
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual User User { get; set; }

       // public virtual ICollection<Favorite> Favorites { get; set; }

    }
}
