using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcTestApp.Models;

namespace MvcTestApp.Controllers

{
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        List<Movie> movies = new List<Movie>() { new Movie() { Name = "3Idiots", Director = "hirani", no = 1 }, new Movie() { Name = "bahubali", Director = "Rajamaouli", no = 2 } };
        // GET: MoviesController
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {

            return View(new myViewModel() { Movies = movies });
        }

        // GET: MoviesController/Details/5
        [HttpGet]
        [Route("details/{directorName}")]
        public ActionResult Details(string directorName)
        {
            List<Movie> movies = new List<Movie>() { new Movie() { Name = "3Idiots", Director = "hirani" }, new Movie() { Name = "bahubali", Director = "Rajamaouli" } };

            var result = movies.Where(x => x.Director == directorName).ToList();

            return View("Index", new myViewModel { Movies = result });
        }
        [Route("Create")]
        // GET: MoviesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviesController/Create
        [HttpPost]
        [Route("Create")]
        
        public ActionResult Create(Movie obj)
        {
            if (obj.Name.Trim().ToLower() == obj.Director.Trim().ToLower())
            {
                ModelState.AddModelError("Name", "name & director are same");
            }
            if (ModelState.IsValid)
            {
                movies.Add(obj);

            }

            return View("Index", new myViewModel { Movies = movies });

        }

        // GET: MoviesController/Edit/5
        [HttpGet]
        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
        Movie movie = movies.Where(x => x.no== id).First();
            return View(movie);
        }

        // POST: MoviesController/Edit/5
        [HttpPost]
        [Route("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditItem(Movie movie)
        {
            Movie olditem = movies.Where(x => x.no == movie.no).First();
            olditem.Name = movie.Name;
            olditem.Director = movie.Director;

            return View("Index", new myViewModel() { Movies = movies });
        }

        // GET: MoviesController/Delete/5
        /*[HttpGet]
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            Movie movie = movies.Where(x => x.no == id).First();
            return View(movie);
        }
        */
        // POST: MoviesController/Delete/5
        //[HttpDelete]
        [Route("Delete/{id}")]
        
        public ActionResult DeleteItem(int id)
        {
            Movie oldItem = movies.Where(x => x.no == id).First();
            movies.Remove(oldItem);
            return View("Index", new myViewModel(){ Movies = movies });
            
        }
    }
}
