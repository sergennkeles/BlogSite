using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Entities
{
    public class Facebook:BaseEntity
    {
        public int UserId { get; set; }
        public string FacebookUrl { get; set; }

        public virtual User User { get; set; }
        
    }
}
