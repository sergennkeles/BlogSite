﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Dtos
{
    public class PostDto:BaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}