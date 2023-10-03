using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;

namespace CleanMovie.Application.Services
{
	public class MovieService: IMovieService
	{
		private readonly IMovieRepository _movieRepository;

		public MovieService(IMovieRepository movieRepository)
		{
			_movieRepository = movieRepository;
		}

		public List<Movie> GetAllMovies()
		{
			var movies = _movieRepository.GetAllMovies();
			return movies;
		}

		public Movie CreateMovie(Movie movie)
		{
			_movieRepository.CreateMovie(movie);
			return movie;
		}
	}
}
