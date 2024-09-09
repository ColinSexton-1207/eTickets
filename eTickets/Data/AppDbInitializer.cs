using eTickets.Models;

namespace eTickets.Data {
    public class AppDbInitializer {
        public static void Seed(IApplicationBuilder applicationBuilder) {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Cinema.Any()) {
                    context.Cinema.AddRange(new List<Cinema> {
                        new Cinema() {
                            CinemaName = "AMC Pekin 14",
                            Logo = "eTickets/wwwroot/imgs/amc.jpg",
                            Description = "Great Stories belong here, with perfect picture, perfect sound, and delicious AMC Perfectly Popcorn. "
                                            + "At AMC Theatres, We Make Movies Better. Get tickets now to begin your next adventure"
                        },
                        new Cinema() {
                            CinemaName = "AMC Grand Prarie 18",
                            Logo = "eTickets/wwwroot/imgs/amc.jpg",
                            Description = "Great Stories belong here, with perfect picture, perfect sound, and delicious AMC Perfectly Popcorn. "
                                            + "At AMC Theatres, We Make Movies Better. Get tickets now to begin your next adventure"
                        },
                        new Cinema() {
                            CinemaName = "VIP Morton Cinemas",
                            Logo = "eTickets/wwwroot/imgs/vipmorton.png",
                            Description = "Family owned and operated and fully dedicated to bring you affordable entertainment in a clean family-friendly environment."
                        },
                        new Cinema() {
                            CinemaName = "Willow Knolls 14",
                            Logo = "eTickets/wwwroot/imgs/willowknolls.png",
                            Description = "At Willow Knolls 14 we deliver movies, munchies, and memories with the best in value cleanliness and customer care. Offering stadium seating, premium "
                                            + "high back lounger seats and featuring 14 screens with all digital projection. Doors open half hour before the first movie."
                        }
                    });
                    context.SaveChanges();
                }

                if(!context.Producers.Any()) {
                    context.Producers.AddRange(new List<Producer> {
                        new Producer() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgscameronmackintosh.jpg",
                            FullName = "Cameron Mackintosh",
                            Bio = "Sir Cameron Anthony Mackintosh is a British theatrical producer and theatre owner notable for his association with many commercially successful musicals."
                        },
                        new Producer() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/carlossaldanha.jpg",
                            FullName = "Carlos Saldanha",
                            Bio = "Carlos Saldanha is a Brazilian animator, director, producer, and voice actor of animated films who worked with Blue Sky Studios until its closure in 2021."
                        },
                        new Producer() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/janethealy.jpg",
                            FullName = "Janet Healy",
                            Bio = "Janet Healy is a film producer whose films include Illumination's Despicable Me animated series and other animated films by the studio."
                        },
                        new Producer() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/reynolds.jpg",
                            FullName = "Ryan Reynolds",
                            Bio = "Ryan Rodney Reynolds OBC is a Canadian and American actor, producer, and businessman. He began his career starring in the Canadian teen soap opera Hillside and had minor roles before landing the lead role on the sitcom Two Guys and a Girl between 1998 and 2001."
                        },
                        new Producer() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/timburton.jpg",
                            FullName = "Tim Burton",
                            Bio = "Timothy Walter Burton is an American director, producer, writer, animator, and illustrator. Known for pioneering goth culture in the American film industry, Burton is famous for his gothic horror and fantasy films."
                        }
                    });
                    context.SaveChanges();
                }

                if(!context.Actors.Any()) {
                    context.Actors.AddRange(new List<Actor> {
                        new Actor() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/amandaseyfried.jpg",
                            FullName = "Amanda Seyfried",
                            Bio = "Amanda Michelle Seyfried is an American actress, singer and songwriter. She began acting at 15, with recurring roles as Lucy Montgomery in the CBS soap opera As the World Turns and Joni Stafford in the ABC soap opera All My Children."
                        },
                        new Actor() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/hughjackman.jpg",
                            FullName = "Hugh Jackman",
                            Bio = "Hugh Michael Jackman AC is an Australian actor. Beginning in theatre and television, Jackman landed his breakthrough role as Wolverine in the X-Men film franchise and the Marvel Cinematic Universe from X-Men to Deadpool & Wolverine."
                        },
                        new Actor() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/stevecarrel.jpg",
                            FullName = "Steve Carrel",
                            Bio = "Steven John Carell is an American actor and comedian. He starred as Michael Scott in the NBC sitcom The Office, and also worked at several points as a producer, executive producer, writer, and director. Carell has received numerous accolades, including a Golden Globe Award for The Office."
                        },
                        new Actor() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/zacharylevi.jpg",
                            FullName = "Zachary Levi",
                            Bio = "Zachary Levi Pugh is an American actor. He starred as Chuck Bartowski in the action comedy series Chuck, and as the title character in the superhero film Shazam! and its 2023 sequel."
                        },
                        new Actor() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/reynolds.jpg",
                            FullName = "Ryan Reynolds",
                            Bio = "Ryan Rodney Reynolds OBC is a Canadian and American actor, producer, and businessman. He began his career starring in the Canadian teen soap opera Hillside and had minor roles before landing the lead role on the sitcom Two Guys and a Girl between 1998 and 2001"
                        },
                        new Actor() {
                            ProfilePictureUrl = "eTickets/wwwroot/imgs/ortega.jpg",
                            FullName = "Jenna Ortega",
                            Bio = "Jenna Marie Ortega is an American actress. She began her career as a child and received recognition for her role as young Jane in The CW comedy-drama series Jane the Virgin. She then won an Imagen Award for her leading role as Harley Diaz in the Disney Channel series Stuck in the Middle."
                        }
                    });
                    context.SaveChanges();
                }

                if(!context.Movies.Any()) {
                    context.Movies.AddRange(new List<Movie> {
                        new Movie() {
                            MovieName = "Beetlejuice Beetlejuice",
                            MovieDescription = "Three generations of the Deetz family return home to Winter River after an unexpected family tragedy. Still haunted by Beetlejuice, Lydia's life soon gets turned upside down when her rebellious teenage daughter discovers a mysterious portal to the afterlife. When someone says Beetlejuice's name three times, the mischievous demon gleefully returns to unleash his very own brand of mayhem.",
                            Price = 7.49,
                            PosterUrl = "eTickets/wwwroot/imgs/bjbj.jpg",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(-15),
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 1,
                            ProducerId = 5
                        },
                        new Movie() {
                            MovieName = "Deadpool and Wolverine",
                            MovieDescription = "Deadpool's peaceful existence comes crashing down when the Time Variance Authority recruits him to help safeguard the multiverse. He soon unites with his would-be pal, Wolverine, to complete the mission and save his world from an existential threat.",
                            Price = 10.99,
                            PosterUrl = "eTickets/wwwroot/imgs/dpw.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-7),
                            MovieCategory = MovieCategory.Action,
                            CinemaId = 2,
                            ProducerId = 4
                        },
                        new Movie() {
                            MovieName = "Despicable Me 4",
                            MovieDescription = "Gru welcomes a new member to the family, Gru Jr., who's intent on tormenting his dad. However, their peaceful existence soon comes crashing down when criminal mastermind Maxime Le Mal escapes from prison and vows revenge against Gru.",
                            Price = 10.99,
                            PosterUrl = "eTickets/wwwroot/imgs/dm4.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-10),
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 2,
                            ProducerId = 3
                        },
                        new Movie() {
                            MovieName = "Harold and the Purple Crayon",
                            MovieDescription = "Inside his book, adventurous Harold can make anything come to life simply by drawing it. After he grows up and draws himself off the book's pages and into the physical world, he soon learns his trusty crayon can set off more hilarious hijinks than he thought possible. However, when the power of unlimited imagination falls into the wrong hands, it will take all of his creativity to save both the real world and his own.",
                            Price = 6.25,
                            PosterUrl = "eTickets/wwwroot/imgs/pcray.jpg",
                            StartDate = DateTime.Now.AddDays(-15),
                            EndDate = DateTime.Now.AddDays(-3),
                            MovieCategory = MovieCategory.Documentary,
                            CinemaId = 3,
                            ProducerId = 2
                        },
                        new Movie() {
                            MovieName = "Les Miserables",
                            MovieDescription = "After 19 years as a prisoner, Jean Valjean (Hugh Jackman) is freed by Javert (Russell Crowe), the officer in charge of the prison workforce. Valjean promptly breaks parole but later uses money from stolen silver to reinvent himself as a mayor and factory owner. Javert vows to bring Valjean back to prison. Eight years later, Valjean becomes the guardian of a child named Cosette after her mother's (Anne Hathaway) death, but Javert's relentless pursuit means that peace will be a long time coming.",
                            Price = 11.00,
                            PosterUrl = "eTickets/wwwroot/imgs/lemis.jpg",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = MovieCategory.Drama,
                            CinemaId = 4,
                            ProducerId = 1
                        }
                    });
                    context.SaveChanges();
                }

                if(!context.ActorsMovies.Any()) {
                    context.ActorsMovies.AddRange(new List<ActorMovie> {
                        new ActorMovie {
                            MovieId = 3,
                            ActorId = 6
                        },

                        new ActorMovie {
                            MovieId = 4,
                            ActorId = 2
                        },
                        new ActorMovie {
                            MovieId = 4,
                            ActorId = 5
                        },

                        new ActorMovie {
                            MovieId = 5,
                            ActorId = 3
                        },

                        new ActorMovie {
                            MovieId = 6,
                            ActorId = 4
                        },

                        new ActorMovie {
                            MovieId = 7,
                            ActorId = 1
                        },
                        new ActorMovie {
                            MovieId = 7,
                            ActorId = 2
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}