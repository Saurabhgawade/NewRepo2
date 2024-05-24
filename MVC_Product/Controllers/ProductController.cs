using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Product.Models;

namespace MVC_Product.Controllers
{
    [Route("[Controller]")]
    public class ProductController : Controller
    {
        // GET: ProductController
        List<Product> ProductList = new List<Product>() { new Product() { Id = 1, ProductName = "Mobile", ProductPrice = 2000 }, new Product() { Id = 2, ProductName = "tablet", ProductPrice = 1000 } };

        [Route("Index")]
        public ActionResult Index()
        {
            return View(new MyView { ProductList=ProductList});
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        [HttpGet]
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [Route("Create")]
       
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductList.Add(product);
            }
            return View("Index", new MyView { ProductList = ProductList });
        }

        // GET: ProductController/Edit/5
        [HttpGet]
        [Route("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            Product product = ProductList.Where(x => x.Id == id).First();
            return View(product);

        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [Route("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            Product oldproduct = ProductList.Where(x => x.Id == product.Id).First();
            oldproduct.ProductName = product.ProductName;
            oldproduct.ProductPrice = product.ProductPrice;

            ProductList.Add(oldproduct);
            return View("Index", new MyView { ProductList = ProductList });
        }

        // GET: ProductController/Delete/5



        // POST: ProductController/Delete/5

        [HttpGet]
        
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            Product product = ProductList.Where(x => x.Id == id).First();

            ProductList.Remove(product);
            return View("Index", new MyView { ProductList = ProductList });
        }
    }
}
