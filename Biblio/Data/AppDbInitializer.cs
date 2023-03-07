
using Biblio.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Biblio.Data
{
    public class AppDbInitializer 
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Authors.Any())
                {

                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            Name = "Author 1",
                            Bio = "This is the Bio of Author 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            genre = Enums.Genre.SciFi
                        },
                        new Author()
                        {
                            Name = "Author 2",
                            Bio = "This is the Bio of Author 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            genre = Enums.Genre.Thriller
                        },
                        new Author()
                        {
                            Name = "Author 3",
                            Bio = "This is the Bio of Author 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            genre = Enums.Genre.Fantasy
                        },
                        new Author()
                        {
                            Name = "Author 4",
                            Bio = "This is the Bio of Author 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            genre = Enums.Genre.Biography
                        },
                        new Author()
                        {
                            Name = "Author 5",
                            Bio = "This is the Bio of Author 5",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            genre = Enums.Genre.Mystery
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Title = "Book 1",
                            Description = "This is the Bio of Book 1",
                            BookCoverURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Rating = 5.5,
                            genre = Enums.Genre.Fantasy,
                            AuthorId = 1                            
                        },
                        new Book()
                        {
                            Title = "Book 2",
                            Description = "This is the Bio of Book 2",
                            BookCoverURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            Rating = 4.9,
                            genre = Enums.Genre.Biography,
                            AuthorId = 2
                        },
                        new Book()
                        {
                            Title = "Book 3",
                            Description = "This is the Bio of Book 3",
                            BookCoverURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            Rating = 2.6,
                            genre = Enums.Genre.Mystery,
                            AuthorId = 3
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
