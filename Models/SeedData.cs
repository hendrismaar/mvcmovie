using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (!context.Movie.Any())
                {
                    AddMovies(context);
                }
                if (!context.Actor.Any())
                {
                    AddActors(context);
                }

                context.SaveChanges();
            }
        }

                private static void AddMovies(MvcMovieContext context)
                {
                    context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "B"
                    }
                );
                }
                private static void AddActors(MvcMovieContext context)
                {
                    context.Actor.AddRange(
                        new Actor
                        {
                            Birthplace = "Tallinn",
                            Birthday = DateTime.Parse("1989-02-12"),
                            FamilyName = "Lamp",
                            GivenName = "Anu",
                            NumberOfOscars = 0,
                        },
                        new Actor
                        {
                            Birthplace = "Hayward",
                            Birthday = DateTime.Parse("1972-05-02"),
                            FamilyName = "Johnson",
                            GivenName = "Dwayne",
                            NumberOfOscars = 0,
                        },
                        new Actor
                        {
                            Birthplace = "Kansas City",
                            Birthday = DateTime.Parse("1964-11-29"),
                            FamilyName = "Cheadle",
                            GivenName = "Don",
                            NumberOfOscars = 0,
                        },
                        new Actor
                        {
                            Birthplace = "Shawnee",
                            Birthday = DateTime.Parse("1963-12-18"),
                            FamilyName = "Pitt",
                            GivenName = "Brad",
                            NumberOfOscars = 2,
                        }
                        );
                }
    }
}