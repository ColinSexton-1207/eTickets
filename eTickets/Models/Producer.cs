using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models {
    public class Producer {
        [Key]
        public int producerId { get; set; }
        
        public string profilePictureUrl { get; set; }
        public string fullName { get; set; }
        public string bio { get; set; }
    }
}