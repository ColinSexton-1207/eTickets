namespace eTickets.Models {
    public class ActorMovie {
        public int ActorId { get; set; }
        public int MovieId { get; set; }
        
        /* --- Map DB Relationships --- */
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}