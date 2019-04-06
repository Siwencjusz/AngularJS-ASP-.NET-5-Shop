using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Shop.EntityFramework.Entities;
using System.IO;

namespace Shop.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Shop.EntityFramework.ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Shop";
        }

        protected override void Seed(Shop.EntityFramework.ShopDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...

            List<BookType> bookTypes = new List<BookType>();
            bookTypes.Add(new BookType()
            {
                Id = 1,
                Name = "AudioBook"
            });
            bookTypes.Add(new BookType()
            {
                Id = 2,
                Name = "E-book"
            });
            context.BookTypes.AddOrUpdate(bookTypes.ToArray());

            List<Author> authors = new List<Author>();
            authors.Add(new Author()
            {
                Id = 1,
                Name = "Jan Stonoga"
            });
            authors.Add(new Author()
            {
                Id = 2,
                Name = "Zbigniew Braun"
            });
            authors.Add(new Author()
            {
                Id = 3,
                Name = "Jaros³aw Kowalski"
            });
            context.Authors.AddOrUpdate(authors.ToArray());

            List<Publisher> publishers = new List<Publisher>();
            publishers.Add(new Publisher()
            {
                Id = 1,
                Name = "Cheeki Breeki"
            });
            publishers.Add(new Publisher()
            {
                Id = 2,
                Name = "Fabryka ksi¹¿ek"
            });
            publishers.Add(new Publisher()
            {
                Id = 3,
                Name = "Wydawnictwo"
            });
            context.Publishers.AddOrUpdate(publishers.ToArray());
            List<Book> books = new List<Book>();

            books.Add(new Book()
            {
                Id = 1,
                BookType = bookTypes[0],
                BookName = "Ksi¹¿ka",
                ReleaseDate = DateTime.Now.AddDays(-10),
                Author = authors[0],
                Publisher = publishers[0],
                Price = 6,
                SuperOpportunity = false
            });
            books.Add(new Book()
            {
                Id = 2,
                BookType = bookTypes[0],
                BookName = "Wolnoœæ w³asnoœæ sprawiedliwoœæ",
                ReleaseDate = DateTime.Now.AddDays(5),
                Author = authors[1],
                Publisher = publishers[1],
                Price = 9.11,
                SuperOpportunity = true
            });
            books.Add(new Book()
            {
                Id = 3,
                BookType = bookTypes[0],
                BookName = "Dowód",
                ReleaseDate = DateTime.Now.AddDays(-50),
                Author = authors[1],
                Publisher = publishers[0],
                Price = 10.04,
                SuperOpportunity = true
            });
            books.Add(new Book()
            {
                Id = 4,
                BookType = bookTypes[1],
                BookName = "A",
                ReleaseDate = DateTime.Now.AddDays(+14),
                Author = authors[0],
                Publisher = publishers[1],
                Price = 14.88,
                SuperOpportunity = false
            });
            books.Add(new Book()
            {
                Id = 5,
                BookType = bookTypes[0],
                BookName = "sssss",
                ReleaseDate = DateTime.Now.AddDays(+7),
                Author = authors[1],
                Publisher = publishers[1],
                Price = 10.02,
                SuperOpportunity = false
            });
            books.Add(new Book()
            {
                Id = 6,
                BookType = bookTypes[1],
                BookName = "¯ubry i dziki",
                ReleaseDate = DateTime.Now.AddDays(-2),
                Author = authors[2],
                Publisher = publishers[1],
                Price = 99.99,
                SuperOpportunity = true
            });
            books.Add(new Book()
            {
                Id = 7,
                BookType = bookTypes[1],
                BookName = "Nad Dnieprem",
                ReleaseDate = DateTime.Now.AddDays(-49),
                Author = authors[2],
                Publisher = publishers[2],
                Price = 32.48,
                SuperOpportunity = true
            });
            context.Books.AddOrUpdate(books.ToArray());



            List<Cover> covers = new List<Cover>();
            covers.Add(new Cover()
            {
                Id = 1,
                Name = "Twarda"
            });
            covers.Add(new Cover()
            {
                Id = 2,
                Name = "Cienka"
            });
            context.Covers.AddOrUpdate(covers.ToArray());

            List<Carrier> carriers = new List<Carrier>();
            carriers.Add(new Carrier()
            {
                Id = 1,
                Name = "CD"
            });
            carriers.Add(new Carrier()
            {
                Id = 2,
                Name = "DVD"
            });
            context.Carriers.AddOrUpdate(carriers.ToArray());

            List<RelEdition> relEditions = new List<RelEdition>();
            relEditions.Add(new RelEdition()
            {
                Id = 1,
                Name = "Bartoszyce 2016"
            });
            relEditions.Add(new RelEdition()
            {
                Id = 2,
                Name = "Olsztyn 2013"
            });
            relEditions.Add(new RelEdition()
            {
                Id = 3,
                Name = "Warszawa 2015"
            });
            context.RelEditions.AddOrUpdate(relEditions.ToArray());
        }
    }
}