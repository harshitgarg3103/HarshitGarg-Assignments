using Microsoft.AspNetCore.Http;
using ClassLibrary1;
using ClassLibrary1.Models;
using ClassLibrary1.Repositories;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ClassLibraryAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        Class1 c = new Class1();
        private readonly MovieRepo mr;
        public LibraryController()
        {
            this.mr = new MovieRepo();
        }
        [HttpGet, Route("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            List<Movie> movies = mr.GetAllMovies();
            return StatusCode(200, movies);
        }
        [HttpGet, Route("GetMovieByName/{name}")]
        public IActionResult GetMovieByNames(string name)
        {
            List<Movie> movie = mr.GetMovieByName(name);
            return StatusCode(200, movie);
        }
        [HttpPost, Route("AddMovie")]
        public IActionResult Add(Movie movie)
        {
            mr.AddMovie(movie);
            return StatusCode(200, "Done adding");
        }
        [HttpGet, Route("GetMovieByActor/{actor}")]
        public IActionResult GetMovieByActors(string actor)
        {
            List<Movie> movie = mr.GetMovieByActor(actor);
            return StatusCode(200, movie);
        }
        [HttpGet, Route("GetMovieByReleaseYear/{year}")]
        public IActionResult GetMovieByYear(int year)
        {
            List<Movie> movie = mr.GetMovieByReleaseYear(year);
            return StatusCode(200, movie);
        }
        [HttpGet, Route("GetMovieByDirector/{director}")]
        public IActionResult GetMovieByDirector(string director)
        {
            List<Movie> movie = mr.GetMovieByDirector(director);
            return StatusCode(200, movie);
        }
    }
}
