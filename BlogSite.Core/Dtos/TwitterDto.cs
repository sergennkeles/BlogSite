using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Dtos
{
    public class TwitterDto : BaseDto
    {
        public int UserId { get; set; }
        public string TwitterUrl{ get; set; }

    }
}
