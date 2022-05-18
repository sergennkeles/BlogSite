using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Post>  Posts { get; set; }
        public List<Comment> Comments { get; set; }

        public Facebook Facebook { get; set; }
        public Twitter Twitter { get; set; }
        public Github Github { get; set; }
        public Instagram Instagram { get; set; }
        public List<Favorite> Favorites { get; set; }
        


    }
}
