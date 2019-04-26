using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CanteenWebApplication.Models;
using System.Dynamic;
using CanteenWebApplication.DAO;

namespace CanteenWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.foods = new FoodDAO().GetAllFoods();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
