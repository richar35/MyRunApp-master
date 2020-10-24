using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyRunApp.Models;

namespace MyRunApp.Controllers
{
    public class ShoeController : Controller
    {
        private ShoeContext context { get; set; }

        public ShoeController(ShoeContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            //ViewBag.Genres = context.Price.OrderBy(g => g.Name).ToList();
            return View("Edit", new Shoe());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            //ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
            var movie = context.Shoes.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Shoe shoe)
        {
            if (ModelState.IsValid)
            {
                if (shoe.ShoeId == 0)
                    context.Shoes.Add(shoe);
                else
                    context.Shoes.Update(shoe);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (shoe.ShoeId == 0) ? "Add" : "Edit";
               //ViewBag.Genres = context.Genres.OrderBy(g => g.Name).ToList();
                return View(shoe);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var shoe = context.Shoes.Find(id);
            return View(shoe);
        }

        [HttpPost]
        public IActionResult Delete(Shoe shoe)
        {
            context.Shoes.Remove(shoe);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}