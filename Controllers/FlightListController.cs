using Flight.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flight.Controllers
{
    public class FlightListController : Controller
    {
        private FlightContext context { get; set; }

        public FlightListController(FlightContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Cities = new List<string>
            {
                "New York",
                "Dallas",
                "Chicago",
                "Los Angeles",
                "Houston",
                "Miami"
            };
            return View("Edit", new FlightList());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewData["IsEdit"] = true;
            ViewBag.Cities = new List<string>
            {
                "New York",
                "Dallas",
                "Chicago",
                "Los Angeles",
                "Houston",
                "Miami"
            };
            var flightId = context.FlightList.Find(id);
            return View(flightId);
        }

        [HttpPost]
        public IActionResult Edit(FlightList flight)
        {
            if (ModelState.IsValid)
            {
                if (flight.FlightListId == 0)
                    context.FlightList.Add(flight);
                else
                    context.FlightList.Update(flight);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (flight.FlightListId == 0) ? "Add" : "Edit";
                return View(flight);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var flightId = context.FlightList.Find(id);
            return View(flightId);
        }

        [HttpPost]
        public IActionResult Delete(FlightList flight)
        {
            context.FlightList.Remove(flight);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
