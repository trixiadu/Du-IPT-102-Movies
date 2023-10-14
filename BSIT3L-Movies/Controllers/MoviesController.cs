using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 4, Name = "The Notebook", Rating = "5", ReleaseYear = 2004, Genre = "Drama/Romance" },
            new MovieViewModel { Id = 5, Name = "Notting Hill", Rating = "5", ReleaseYear = 1999, Genre = "Romance/Comedy" },
            new MovieViewModel { Id = 6, Name = "Enola Holmes", Rating = "5", ReleaseYear = 2020, Genre = "Mystery/Crime" },
            new MovieViewModel { Id = 7, Name = "Barbie", Rating = "4", ReleaseYear = 2023, Genre = "Comedy/Fantasy" },
            new MovieViewModel { Id = 8, Name = "Past Lives", Rating = "5", ReleaseYear = 2023, Genre = "Drama/Romance" },
            new MovieViewModel { Id = 9, Name = "Tin & Tina", Rating = "4", ReleaseYear = 2023, Genre = "Horror/Thriller" },
            new MovieViewModel { Id = 10, Name = "Spirited Away", Rating = "5", ReleaseYear = 2001, Genre = "Fantasy/Adventure" },
            new MovieViewModel { Id = 11, Name = "Mean Girls", Rating = "5", ReleaseYear = 2004, Genre = "Comedy/Teen" },
            new MovieViewModel { Id = 12, Name = "Corpse Bride", Rating = "5", ReleaseYear = 2005, Genre = "Family/Musical" },
            new MovieViewModel { Id = 13, Name = "Midnight Runners", Rating = "5", ReleaseYear = 2017, Genre = "Action/Comedy" },
            new MovieViewModel{ Id = 14, Name = "The Devils Wear Prada", Rating = "5", ReleaseYear = 2006, Genre = "Drama/Comedy" },
            new MovieViewModel { Id = 15, Name = "One More Chance", Rating = "5", ReleaseYear = 2007, Genre = "Romance/Drama" }
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

