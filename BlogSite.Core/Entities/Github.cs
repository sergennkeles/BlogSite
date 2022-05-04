using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class Github : BaseEntity
    {
        public Guid UserId { get; set; }
        public string GithubUrl { get; set; }
     
    }
   
}
