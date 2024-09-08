using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace eTickets.Data {
    // Translator between Models and DB
    /* --- Model <--> DbContext <--> Database */
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { // Basically DbContext() == base(options)
            // this.options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ActorMovie>().HasKey(am => new {
                am.actorId,
                am.movieId
            });

            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Actor).WithMany(am => am.actorsMovies).HasForeignKey(m => m.actorId);
            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.actorsMovies).HasForeignKey(m => m.movieId);

            base.OnModelCreating(modelBuilder);
        }

        /* --- Table Management --- */
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set;}
        public DbSet<ActorMovie> ActorsMovies { get; set;}
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}