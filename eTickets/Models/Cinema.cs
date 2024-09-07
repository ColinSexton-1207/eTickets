using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models {
    public class Cinema {
        [Key]
        public int cinemaId { get; set; }
        public string logo { get; set; }
        public string cinemaName { get; set; }
        public string description { get; set; }
    }
}