using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Meetup.Data;
using System;
using System.Linq;

namespace Meetup.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MeetupContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MeetupContext>>()))
            {
                // Look for any movies.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                    new Person
                    {
                        FirstName = "Alan",
                        LastName = "Nash",
                        Birthday = DateTime.Parse("1962-06-16"),
                        Interest = "Golf"
                    },

                    new Person
                    {
                        FirstName = "Gertrude",
                        LastName = "Valdez",
                        Birthday = DateTime.Parse("1973-04-22"),
                        Interest = "Volleyball"
                    },

                    new Person
                    {
                        FirstName = "Gina",
                        LastName = "Bishop",
                        Birthday = DateTime.Parse("1979-04-02"),
                        Interest = "Soccer"
                    },

                    new Person
                    {
                        FirstName = "Jeremy",
                        LastName = "Lynch",
                        Birthday = DateTime.Parse("1982-08-21"),
                        Interest = "Golf"
                    },

                    new Person
                    {
                        FirstName = "Lionel",
                        LastName = "Caldwell",
                        Birthday = DateTime.Parse("1984-04-11"),
                        Interest = "Volleyball"
                    },

                    new Person
                    {
                        FirstName = "Alberta",
                        LastName = "Drake",
                        Birthday = DateTime.Parse("1989-06-22"),
                        Interest = "Hiking"
                    },

                    new Person
                    {
                        FirstName = "Kelli",
                        LastName = "Simon",
                        Birthday = DateTime.Parse("1990-12-30"),
                        Interest = "Golf"
                    },

                    new Person
                    {
                        FirstName = "Alice",
                        LastName = "Shelton",
                        Birthday = DateTime.Parse("1995-05-30"),
                        Interest = "Hiking"
                    },

                    new Person
                    {
                        FirstName = "Delia",
                        LastName = "Mcdonald",
                        Birthday = DateTime.Parse("1997-04-03"),
                        Interest = "Volleyball"
                    },


                    new Person
                    {
                        FirstName = "Rudy",
                        LastName = "Curry",
                        Birthday = DateTime.Parse("2000-02-25"),
                        Interest = "Soccer"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}


/*
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Meetup.Data;
using System;
using System.Linq;

namespace Meetup.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MeetupContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MeetupContext>>()))
            {
                // Look for any movies.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                    new Person
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Person
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },

                    new Person
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },

                    new Person
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
*/