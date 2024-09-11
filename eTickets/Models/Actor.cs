using System.ComponentModel.DataAnnotations;

namespace eTickets.Models {
    public class Actor {
        [Key]
        public int ActorId { get; set; }
        
        [Display(Name = "Profile Picture")]
        public string? ProfilePictureUrl { get; set; }   
        [Display(Name = "Actor")]
        [Required(ErrorMessage = "Actor name is required")]
        [StringLength(75, MinimumLength = 3, ErrorMessage = "Actor name must be between 3 and 75 characters")]
        public string? FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Actor biography required")]
        [StringLength(1500, MinimumLength = 3, ErrorMessage = "Actor name must be between 3 and 75 characters")]
        public string? Bio { get; set; }

        /* --- Map DB Relationships --- */
        public List<ActorMovie> ActorsMovies { get; set; }
    }
}