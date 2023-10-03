using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;

namespace CleanMovie.Infrastructure.Repositories
{
	public class MovieRepository:IMovieRepository
	{
		//public static List<Movie> Movies = new List<Movie>
		//{
		//	new Movie {Id = 1, MovieName = "The Matrix", RentalCost = 10.00m},
		//	new Movie {Id = 2, MovieName = "The Matrix Reloaded", RentalCost = 10.00m},
		//	new Movie {Id = 3, MovieName = "The Matrix Revolutions", RentalCost = 10.00m},
		//	new Movie {Id = 4, MovieName = "The Matrix 4", RentalCost = 10.00m}
		//};

		private readonly MovieDbContext _movieDbContext;
		public MovieRepository(MovieDbContext movieDbContext)
		{
			_movieDbContext = movieDbContext;
		}
		public List<Movie> GetAllMovies()
		{
			return _movieDbContext.Movies.ToList();
		}

		public Movie CreateMovie(Movie movie)
		{
			_movieDbContext.Movies.Add(movie);
			_movieDbContext.SaveChanges();
			return movie;
		}
	}
}
