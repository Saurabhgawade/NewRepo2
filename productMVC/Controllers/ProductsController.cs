using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productMVC.Models;

namespace productMVC.Controllers
{
    [Route("[Controller]")]
    public class ProductsController : Controller
    {
        List<Product> productList = new List<Product>() { new Product { productId = 1,productName="mobile", productPrice = 2000 },new Product { productId=2,productName="headphone",productPrice=1200} };

        // GET: ProductsController
        [HttpGet]
        [Route("Index")]
        public ActionResult Index()
        {
            return View(new MyViewModel() { ProductsList=productList});
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        [HttpGet]
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [Route("Create")]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productList.Add(product);
            }
            return View("Index", new MyViewModel() { ProductsList = productList });
        }

        // GET: ProductsController/Edit/5
        [HttpGet]
        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            var product = productList.Where(x => x.productId == id).FirstOrDefault();
            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit/{id}")]
        public ActionResult Edit(Product product)
        {
            Product olditem = productList.Where(x => x.productId == product.productId).FirstOrDefault();
            olditem.productName = product.productName;
            olditem.productPrice = product.productPrice;

            return View("Index", new MyViewModel() { ProductsList = productList });
            
        }

        // GET: ProductsController/Delete/5

        

        // POST: ProductsController/Delete/5
        
     
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            Product product = productList.Where(x => x.productId == id).FirstOrDefault();
            productList.Remove(product);
            return View("Index", new MyViewModel() { ProductsList = productList });
        }
    }
}
