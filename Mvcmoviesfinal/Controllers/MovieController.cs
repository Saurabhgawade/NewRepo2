using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mvcmoviesfinal.Models;

namespace Mvcmoviesfinal.Controllers
{
    [Route("[Controller]")]
    public class MovieController : Controller
    {
        List<Movie> movies = new List<Movie>() { new Movie() { Id = 1, Name = "abc", Director = "bfjg" }, new Movie() { Id = 2, Name = "nfmkf", Director = "jdn" } };
        // GET: MovieController

        [Route("Index")]
        public ActionResult Index()
        {
            return View(new MyView() { movielist=movies});
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
