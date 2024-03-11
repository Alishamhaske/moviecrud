using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using moviecrud.Models;
using moviecrud.Services;

namespace moviecrud.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieServices service;
        public MovieController(IMovieServices service)
        {
            this.service = service;
        }
        // GET: MovieController
        public ActionResult Index()
        {
           return View(service.GetMovies());    
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
           var model =service.GetMovieById(id);
            return View(model);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            try
            {
                int result = service.AddMovie(movie);
                if(result>=1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
        
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = service.GetMovieById(id);
            return View(movie);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                int result=service.UpdateMovie(movie);
                if(result>=1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
               
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            var movie=service.GetMovieById(id); 
            return View(movie);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id )
        {
            try
            {
                int result=service.DeleteMovie(id);
                if(result>=1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
             
            }
            catch
            {
                return View();
            }
        }
    }
}
