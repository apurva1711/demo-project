using mvcMovieNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcMovieNew.Controllers
{
    public class HomeController : Controller
    {
        private static List<Movie> moviesList = new List<Movie>();



        public ActionResult Index()
        {
            if (moviesList.Count <= 0)
            {
                moviesList.Add(new Movie(1, "Star War", "Abc"));
                moviesList.Add(new Movie(2, "Star", "xyz"));
                moviesList.Add(new Movie(3, "Star War New", "pqr"));
            }
            return View(moviesList);
        }

        public ActionResult Details(int id)
        {
            var movieToEdit = (from m in moviesList
                               where m.Id == id
                               select m).First();
            return View(movieToEdit);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Movie movieToCreate)
        {
            //if (!ModelState.IsValid)
            //    return View();
            movieToCreate.Id = moviesList.Count + 1;
            movieToCreate.Title = "Movie Title 2 " + movieToCreate.Id;
            movieToCreate.Director = "Movie Director 2 " + movieToCreate.Id;
            moviesList.Add(movieToCreate);

           return RedirectToAction("Index");
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            var movieToEdit = (from m in moviesList
                               where m.Id == id
                               select m).First();

            return View(movieToEdit);
        }

        //
        // POST: /Home/Edit/5

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(Movie movieToEdit)
        {

            
            moviesList.Add(movieToEdit);
            
        
            return RedirectToAction("Index");
        }


    }
}