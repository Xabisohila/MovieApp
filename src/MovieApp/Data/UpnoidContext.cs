using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class UpnoidContext:DbContext
    {
        public UpnoidContext(DbContextOptions<UpnoidContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Trailer> Trailers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Genre>().ToTable("Genre");
            modelbuilder.Entity<Movie>().ToTable("Movie");
            modelbuilder.Entity<Rental>().ToTable("Rental");
            modelbuilder.Entity<Trailer>().ToTable("Trailer");
            modelbuilder.Entity<Customer>().ToTable("Customer");
            base.OnModelCreating(modelbuilder);
        }
    }
}
