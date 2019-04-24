using Microsoft.AspNetCore.Mvc;
using WildlifeRefuge.Models;
using System.Linq;

namespace WildlifeRefuge.Controllers
{
    public class AnimalController : Controller
    {
        private readonly WildlifeRefugeDbContext context;

        public AnimalController(WildlifeRefugeDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var allAnimals = context.Animals.ToList();
            return View(allAnimals);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal animal)
        {
            if (ModelState.IsValid)
            {
                context.Add(animal);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var animalToEdit = context.Animals.Where(x => x.Id == id).FirstOrDefault();
            if (animalToEdit != null)
            {
                return View(animalToEdit);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Animal animal)
        {
            if (ModelState.IsValid)
            {
                context.Update(animal);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var animalToDelete = context.Animals.Where(x => x.Id == id).FirstOrDefault();
            if (animalToDelete != null)
            {
                return View(animalToDelete);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Animal animal)
        {
            context.Remove(animal);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}