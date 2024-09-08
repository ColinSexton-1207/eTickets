namespace eTickets.Models {
    public class ActorMovie {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        
        /* --- Map DB Relationships --- */
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
    }
}