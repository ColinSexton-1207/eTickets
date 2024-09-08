using System.ComponentModel.DataAnnotations;

namespace eTickets.Models {
    public class Cinema {
        [Key]
        public int CinemaId { get; set; }
        
        public string Logo { get; set; }
        public string CinemaName { get; set; }
        public string Description { get; set; }

        /* --- Map DB Relationships --- */
        public List<Movie> Movies { get; set; }
    }
}