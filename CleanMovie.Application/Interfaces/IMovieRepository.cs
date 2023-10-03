using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanMovie.Domain;

namespace CleanMovie.Application.Interfaces
{
	public interface IMovieRepository
	{
		List<Movie> GetAllMovies();
		Movie CreateMovie(Movie movie);
	}
}
