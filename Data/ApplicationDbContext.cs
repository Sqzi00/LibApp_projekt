using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibApp.Models;

namespace LibApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)

        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
            builder.Entity<Customer>().HasData(

                new Customer
                {
                    Id = 1,
                    Name = "Pawel ",
                    Birthdate = new DateTime(2001, 11, 21),
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 1

                },
                new Customer
                {
                    Id = 2,
                    Name = "ALA",
                    Birthdate = new DateTime(2002, 12, 2),
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 2

                },
              
                new Customer
                {
                    Id = 3,
                    Name = "Ola ciska",
                    Birthdate = new DateTime(2003, 3, 23),
                    HasNewsletterSubscribed = false,
                    MembershipTypeId = 3

                }
               
                
                



                );
            builder.Entity<Book>().HasData(
            new Book
            {
                Id = 5,
                Name = "Nela",
                GenreId = 2,
                AuthorName = "Mroz",
                DateAdded = new DateTime(2000, 11, 12),
                ReleaseDate = new DateTime(1999, 1, 10)

            },
            new Book
            {
                Id = 6,
                Name = "Damian",
                GenreId = 1,
                AuthorName = "jax",
                DateAdded = new DateTime(2000, 1, 12),
                ReleaseDate = new DateTime(1999, 1, 10)

            },          

            new Book
            {
                Id = 7,
                Name = "Ogien i Wiara",
                GenreId = 3,
                AuthorName = "Mroz",
                DateAdded = new DateTime(2000, 1, 12),
                ReleaseDate = new DateTime(1999, 1, 10)

            }


            ) ; 
        }
    }
}
