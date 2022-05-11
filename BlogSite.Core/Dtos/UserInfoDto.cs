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

        public Facebook Facebook { get; set; }
        public int TwitterId { get; set; }
        public int GithubId { get; set; }
        public int InstagramId { get; set; }
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public int FavoriteId { get; set; }
        


    }
}
