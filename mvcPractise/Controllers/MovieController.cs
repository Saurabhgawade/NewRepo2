using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvcPractise.Models;

namespace mvcPractise.Controllers
{
    [Route("[Controller]")]
    public class MovieController : Controller
    {
        
        // GET: MovieController
        List<Movie> movies = new List<Movie>() { new Movie() { id=1,Name="Bahubali",Director="Rajamauli"},
        new Movie(){id=2,Name="3idiots",Director="Hirani"}};

        //Movie movie = new Movie() { Name = "dsvs", Director = "vbb" };
        
        [Route("Index")]
        [HttpGet]
        public ActionResult Index()
        {
            return View(new MyModel() { Movies=movies});
        }

       // GET: MovieController/Details/5
        [HttpGet]
        [Route("details/{directorname}")]
        public ActionResult Details(string directorname)
        {

            var list = movies.Where(x => x.Director == directorname).ToList();


            return View("Index", new MyModel() { Movies = list });
        }

        // GET: MovieController/Create

        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [Route("Create")]
        public ActionResult Create(Movie movie)
        {
            if (movie.Name.Trim().ToLower() == movie.Director.Trim().ToLower())
            {
                ModelState.AddModelError("Name", "Name director same");
            }
            if (ModelState.IsValid)
            {
                movies.Add(movie);
            }
            return View("Index", new MyModel() { Movies = movies });
        }

        // GET: MovieController/Edit/5

        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            Movie movie = movies.Where(x => x.id == id).FirstOrDefault();
            return View(movie);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [Route("Edit/{id}")]

        public ActionResult Edit(Movie movie)
        {
            Movie old = movies.Where(x => x.id == movie.id).FirstOrDefault();

            old.Name = movie.Name;
            old.Director = movie.Director;

            return View("Index", new MyModel() { Movies = movies });
        }

        //GET: MovieController/Delete/5
        [HttpGet]
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            Movie movie = movies.Where(x => x.id == id).FirstOrDefault();
            movies.Remove(movie);
            return View("Index", new MyModel() { Movies = movies });
        }

        //// POST: MovieController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
