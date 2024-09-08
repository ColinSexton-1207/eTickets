using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using eTickets.Data;

namespace eTickets.Models {
    public class Movie {
        [Key]
        public int movieId { get; set; }

        public string movieName { get; set; }
        public string movieDescription { get; set; }
        public double price { get; set; }
        public string posterUrl { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public MovieCategory movieCategory { get; set; }

        // Relationships
        public List<ActorMovie> actorsMovies { get; set; }
    }
}