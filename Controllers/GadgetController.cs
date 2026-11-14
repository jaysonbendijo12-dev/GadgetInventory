
using Microsoft.AspNetCore.Mvc;
using GadgetInventory.Models;

namespace GadgetInventory.Controllers
{
    public class GadgetController : Controller
    {
        
        private static List<Gadget> gadgets = new List<Gadget>();

       
        public IActionResult Index()
        {
            return View(gadgets);
        }

        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Gadget gadget)
        {
            if (ModelState.IsValid)
            {
                gadget.Id = gadgets.Count + 1;
                gadgets.Add(gadget);

                return RedirectToAction("Index");
            }

            return View(gadget);
        }
    }
}

