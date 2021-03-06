﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment : Base
    {
        public int polelike { get; set; }

        public string CommentText { get; set; }
        public string LoginUser { get; set; }
        public DateTime DateComment { get; set; } = DateTime.Now;
        public int PublicationID { get; set; }
        public virtual Publication Publication { get; set; }
    }
}
