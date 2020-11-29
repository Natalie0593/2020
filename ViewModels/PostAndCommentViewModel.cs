using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels
{
    public class PostAndCommentViewModel
    {
        public Publication post { get; set; }
        public CreateCommentViewModel comment { get; set; }
    }
}
