using Flight.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flight.Controllers
{
    public class HomeController : Controller
    {
        private FlightContext context { get; set; }

        public HomeController(FlightContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var flights = context.FlightList.OrderBy(m => m.FlightListId).ToList();
            return View(flights);
        }
    }
}
