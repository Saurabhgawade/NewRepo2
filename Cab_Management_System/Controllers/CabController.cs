using Cab_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cab_Management_System.Controllers
{
    public class CabController : Controller
    {
        private List<Cab> cabList = new List<Cab>() { new Cab() { CabId = 1, From = "Baramati", Too = "Pune", Amount = 1200 },new Cab() { CabId=2,From="Bhigwan",Too="Indapur",Amount=1700} };
        // GET: Cab
        [Route("Index")]        
        
        public ActionResult Index()
        {
            return View(new MyView { CabList=cabList});
        }

        // GET: Cab/Details/5
        [Route("Details")]
        public ActionResult Details()
        {

            return View("Index",new MyView { CabList=cabList});
        }

        // GET: Cab/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cab/Create
        [HttpPost]
        [Route("Create")]
        public ActionResult Create(Cab cabobj)
        {
            if (ModelState.IsValid)
            {
                cabList.Add(cabobj);
            }
            return View("Index", new MyView{ CabList=cabList});
        }

        // GET: Cab/Edit/5
        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            Cab cab = cabList.Where(x => x.CabId == id).FirstOrDefault();
            return View(cab);
        }

        // POST: Cab/Edit/5
        [HttpPost]
        [Route("Edit/{id}")]
        public ActionResult Edit(Cab cabobj)
        {
            var oldresult = cabList.Where(x => x.CabId == cabobj.CabId).FirstOrDefault();
            oldresult.From = cabobj.From;
            oldresult.Too = cabobj.Too;
            oldresult.Amount = cabobj.Amount;

            cabList.Add(oldresult);
            return View("Index", new MyView { CabList = cabList });
        }

        // GET: Cab/Delete/5
        [HttpGet]
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            var item = cabList.Where(x => x.CabId == id).FirstOrDefault();
            cabList.Remove(item);
            return View("Index",new MyView { CabList=cabList});
        }

        // POST: Cab/Delete/5
       
    }
}
