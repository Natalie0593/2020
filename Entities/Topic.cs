using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Topic : Base
    {

        public string NameTopic { get; set; }
        public List<Publication> Publications { get; set; }
    }
}
