using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanMovie.Infrastructure
{
	public class MovieDbContext: DbContext
	{
		public MovieDbContext(DbContextOptions<MovieDbContext> options):base(options)
		{
			
		}
		public DbSet<Movie> Movies { get; set; }

		// protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	// one to many relationship
		//	modelBuilder.Entity<Member>().HasOne(m => m.Rental).WithMany(r => r.Members).HasForeignKey(m => m.RentalId);
		//	// many to many relationship
		//	modelBuilder.Entity<MovieRental>().HasKey(mr => new {mr.MovieId, mr.RentalId});
		//	// handle decimal to avoid precision loss
		//	modelBuilder.Entity<Rental>().Property(r => r.TotalCost).HasPrecision(18, 2);
		//	modelBuilder.Entity<Movie>().Property(m => m.RentalCost).HasPrecision(18, 2);
		//}

		//public DbSet<Member> Members { get; set; }
		//public DbSet<Rental> Rentals { get; set; }
		//public DbSet<MovieRental> MovieRentals { get; set; }

	}
}
