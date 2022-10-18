using Microsoft.EntityFrameworkCore;
using MovieStoreWebApi.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace MovieStoreWebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.AddRange(
                    new ActorActress
                    {
                        Name = "Jeff",
                        Surname = "Bridges",
                    },

                    new ActorActress
                    {
                        Name = "Matt",
                        Surname = "Damon",
                    },

                    new ActorActress
                    {
                        Name = "Ben",
                        Surname = "Affleck",
                    },

                    new ActorActress
                    {
                        Name = "Tom",
                        Surname = "Hanks",
                    });

                context.AddRange(
                    new Director
                    {
                        Name = "Joel",
                        Surname = "Coen"
                    },

                    new Director
                    {
                        Name = "Steven",
                        Surname = "Spielberg"
                    },

                    new Director
                    {
                        Name = "David",
                        Surname = "Fincher"
                    });

                context.AddRange(
                    new Genre
                    {
                        GenreTitle = "Western"
                    },
                    new Genre
                    {
                        GenreTitle = "Comedy"
                    },
                    new Genre
                    {
                        GenreTitle = "Drama"
                    });

                context.AddRange(
                    new Movie
                    {
                        Title = "Big Lebowski",
                        DirectorId = 1,
                        GenreId = 2,
                        Price = 49.90
                    },

                     new Movie
                     {
                         Title = "True Grit",
                         DirectorId = 1,
                         GenreId = 1,
                         Price = 44.90
                     },

                      new Movie
                      {
                          Title = "Saving Private Ryan",
                          DirectorId = 2,
                          GenreId = 3,
                          Price = 34.90
                      },

                      new Movie
                      {
                          Title = "Gone Girl",
                          DirectorId = 3,
                          GenreId = 3,
                          Price = 34.90
                      });

                context.AddRange(
                    new ActorActressMovieJoint
                    {
                        ActorActressId = 1,
                        MovieId = 1
                    },

                    new ActorActressMovieJoint
                    {
                        ActorActressId = 2,
                        MovieId = 1
                    },

                    new ActorActressMovieJoint
                    {
                        ActorActressId = 3,
                        MovieId = 1
                    });

                context.SaveChanges();

            }
        }
    }
}
