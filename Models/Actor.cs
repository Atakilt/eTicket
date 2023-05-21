using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eticket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        //Relationships
        public List<ActorMovie> ActorMovies { get; set; } 
    }
}