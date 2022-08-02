using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1.Models;
using System.Threading.Tasks;

namespace ClassLibrary1.Repositories
{
    public class MovieRepo: MovieInterface
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie(){ id=1234,name="Jai Ho",language="Hindi",releaseDate=2000,actor="Salman Khan",director="Sajid"}
        };
        public void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }
        public List<Movie> GetAllMovies()
        {
            return movies;
        }
        public List<Movie> GetMovieByName(string name)
        {
            List<Movie> l = new List<Movie>();
            foreach(var m in movies)
            {
                if (m.name.Equals(name))
                    l.Add(m);
            }
            return l;
        }
        public List<Movie> GetMovieByActor(string actor)
        {
            List<Movie> l = new List<Movie>();
            foreach (var m in movies)
            {
                if (m.actor.Equals(actor))
                    l.Add(m);
            }
            return l;
        }
        public List<Movie> GetMovieByReleaseYear(int year)
        {
            List<Movie> l = new List<Movie>();
            foreach (var m in movies)
            {
                if (m.releaseDate==year)
                    l.Add(m);
            }
            return l;
        }
        public List<Movie> GetMovieByDirector(string director)
        {
            List<Movie> l = new List<Movie>();
            foreach (var m in movies)
            {
                if (m.director.Equals(director))
                    l.Add(m);
            }
            return l;
        }

    }
}
