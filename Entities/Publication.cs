﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Publication : Base
    {

        public string PublicationName { get; set; }
        public string Discription { get; set; }
        public string PublicationText { get; set; }
        public string ImgUrlPublication { get; set; }
        public bool isFavorite { get; set; }
        public int LikePost { get; set; }
        public DateTime DatePublication { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
        public List<Comment> Comments { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
        public byte[] AvatarPost { get; set; }
        public byte[] AvatarPost2 { get; set; }

    }
}
