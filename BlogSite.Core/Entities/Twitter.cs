using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class Twitter:BaseEntity
    {
        public Guid UserId { get; set; }
        public string TwitterUrl { get; set; }
    }
}
