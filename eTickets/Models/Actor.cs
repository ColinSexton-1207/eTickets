using System.ComponentModel.DataAnnotations;

namespace eTickets.Models {
    public class Actor {
        [Key]
        public int ActorId { get; set; }
        
        public string ProfilePictureUrl { get; set; }   
        public string FullName { get; set; }
        public string Bio { get; set; }

        /* --- Map DB Relationships --- */
        public List<ActorMovie> ActorsMovies { get; set; }
    }
}