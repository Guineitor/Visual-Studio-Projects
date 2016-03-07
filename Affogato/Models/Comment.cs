﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Affogato.Models
{
    public class Comment
    {
        public string Author { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAtUtc { get; set; }

        public int Likes { get; set; }
    }
}