using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Video : Base
    {

        public string Name { get; set; }
        public string Url { get; set; }
        public Publication  Publication {get; set;}
        public int PublicationId { get; set; }
        
    }
}
