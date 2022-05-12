using BlogSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Dtos
{
    public class UserInfoDto:BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public FacebookDto Facebook { get; set; }
        public TwitterDto Twitter{ get; set; }
        public GithubDto Github { get; set; }
        public InstagramDto Instagram { get; set; }
        public PostDto Post { get; set; }
        public CommentDto Comment { get; set; }
        public int FavoriteId { get; set; }
        


    }
}
