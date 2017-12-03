using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { ID = 1, Name = "Shrek!" };
            ViewData["Movie"] = movie;
            ViewBag.Movie= movie;
            return View("Random");
        }

       // [Route("Movie/RandomMovie/{MovieName}/{ReleaseYear:regex(^\\d{4}$):max(2019):min(2005)}")]
        public ActionResult RandomMovie(String MovieName, String ReleaseYear)
        {
            String content = String.Format("Movie Name = {0} and Release Year = {1}", MovieName, ReleaseYear);
            return Content(content);
            
        }

        public ActionResult Index()
        {

            return View(GetMovie());
        }

        private IEnumerable<Movie> GetMovie()
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie { ID = 1, Name = "Amazon ovizan" });
            Movies.Add(new Movie { ID=2,Name = "Chander Pahar"});
            return Movies;
        }
    }
}