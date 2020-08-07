using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = GetProducts();
            return View(products);
        }

        [HttpPost]
        public IActionResult Edit(List<Product> product, string[] DeleteImageIdArr)
        {
            var products = GetProducts();

            return View("Index", products);
        }

        public List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product{ Id=1, Name="Test 1", Description="Test 1", ImageIdArr=new int[]{ 1,2,3 } },
                new Product{ Id=1, Name="Test 2", Description="Test 2", ImageIdArr=new int[]{ 4,5,6 } },
                new Product{ Id=1, Name="Test 3", Description="Test 3", ImageIdArr=new int[]{ 7,8,9 } },
            };

            return products;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] ImageIdArr { get; set; }
    }
}
