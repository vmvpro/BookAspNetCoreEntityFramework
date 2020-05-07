using Chapter11_WorkingWithEFCore.Models;
using Microsoft.AspNetCore.Mvc;

// ReSharper disable once CheckNamespace
namespace Chapter11_WorkingWithEFCore
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View(new Product[] {
				new Product {   Name = "PI",    Category = "Catl",  Price = 10  },
				new Product {   Name = "P2",    Category = "Cat2",  Price = 20  },
				new Product {   Name = "P3",    Category = "Cat3",  Price = 30  }
			});
		}
	}
}
