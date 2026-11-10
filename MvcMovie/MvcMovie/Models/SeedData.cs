using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "PG-13",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Captain America - Civil War ",
                    ReleaseDate = DateTime.Parse("2016-02-04"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 29.99M
                },
                new Movie
                {
                    Title = "The Bourne Legacy",
                    ReleaseDate = DateTime.Parse("2012-2-23"),
                    Genre = "Action",
                    Rating = "PG-13",
                    Price = 29.99M
                },
                new Movie
                {
                    Title = "Bruce Almighty",
                    ReleaseDate = DateTime.Parse("2003-4-15"),
                    Genre = "Comedy",
                    Rating = "PG-13",
                    Price = 19.99M
                }
            );
            context.SaveChanges();
        }
    }
}