using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var listOfMovies = _context.Movies.ToList();
            return View(listOfMovies);
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers1 = new List<Customers>
            {
                new Customers {Name = "Customer 1" },
                new Customers { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers1
            };
            return View(viewModel);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            return View(movie);
        }
        public ActionResult NewMovie()
        {
            var genres = _context.Gernes.Select(m => m.Name.ToString()).ToList();
            var viewModel = new NewMovieViewModel() {Genre = genres };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.Id == 0)
                {
                    movie.DateAdded = DateTime.Now;
                    _context.Movies.Add(movie);
                }
                else
                {
                    var movieInDb = _context.Movies.First(m => m.Id == movie.Id);
                    movieInDb.Name = movie.Name;
                    movieInDb.NumberInStock = movie.NumberInStock;
                    movieInDb.GenreName = movie.GenreName;
                    movieInDb.ReleaseDate = movie.ReleaseDate;

                }


                _context.SaveChanges();

                return RedirectToAction("Index", "Movies");
            }
            else
            {
                var genres = _context.Gernes.Select(m => m.Name.ToString()).ToList();
                var viewModel = new NewMovieViewModel() { Genre = genres, Movie = movie };
                return View("NewMovie", viewModel);
            }

        }
        public ActionResult Edit(int id)
        {
            
            var genres = _context.Gernes.Select(m => m.Name.ToString()).ToList();
            var movie = _context.Movies.SingleOrDefault (m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new NewMovieViewModel() { Genre = genres, Movie = movie };

            return View(viewModel);
        }
    }
}
