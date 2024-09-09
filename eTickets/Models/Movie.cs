using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using eTickets.Data;

namespace eTickets.Models {
    public class Movie {
        [Key]
        public int MovieId { get; set; }

        [Display(Name = "Title")]
        public string MovieName { get; set; }
        [Display(Name = "Description")]
        public string MovieDescription { get; set; }
        public double Price { get; set; }
        [Display(Name = "Poster")]
        public string PosterUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; }

        /* --- Map DB Relationships --- */
        public List<ActorMovie> ActorsMovies { get; set; }

        /* --- Cinema --- */
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        /* --- Producer --- */
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}