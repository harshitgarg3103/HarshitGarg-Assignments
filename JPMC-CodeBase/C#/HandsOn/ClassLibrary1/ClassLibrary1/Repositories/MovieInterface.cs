using System;
using ClassLibrary1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories
{
    public interface MovieInterface
    {
        public void AddMovie(Movie movie);
        public List<Movie> GetAllMovies();
        public List<Movie> GetMovieByName(string name);
        public List<Movie> GetMovieByActor(string actor);
        public List<Movie> GetMovieByReleaseYear(int year);
        public List<Movie> GetMovieByDirector(string director);

    }
}
