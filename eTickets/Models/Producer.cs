using System.ComponentModel.DataAnnotations;

namespace eTickets.Models {
    public class Producer {
        [Key]
        public int ProducerId { get; set; }
        
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Producer Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        /* --- Map DB Relationships --- */
        public List<Movie> Movies { get; set; }
    }
}