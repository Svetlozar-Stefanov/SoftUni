using RescueRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RescueRegister.Controllers
{
    public class MountaineerController : Controller
    {
        private readonly RescueRegisterDbContext context;

        public MountaineerController(RescueRegisterDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var allInfo = context.Mountaineers.ToList();
            return View(allInfo);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mountaineer mountaineer)
        {
            if (ModelState.IsValid)
            {
                context.Add(mountaineer);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var infoToEdit = context.Mountaineers.Where(x => x.Id == id).FirstOrDefault();
            if (infoToEdit != null)
            {
                return View(infoToEdit);
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Edit(Mountaineer mountaineer)
        {
            if (ModelState.IsValid)
            {
                context.Update(mountaineer);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var infoToDelete = context.Mountaineers.Where(x => x.Id == id).FirstOrDefault();
            if (infoToDelete != null)
            {
                return View(infoToDelete);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Mountaineer mountaineer)
        {
            context.Remove(mountaineer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}