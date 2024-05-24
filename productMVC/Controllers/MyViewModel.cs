using productMVC.Models;

namespace productMVC.Controllers
{
    internal class MyViewModel
    {
        public MyViewModel()
        {
        }

        public List<Product> ProductsList { get; set; }
    }
}