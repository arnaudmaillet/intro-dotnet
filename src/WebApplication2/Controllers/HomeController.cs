using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using DataProvider;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller

    {
        private PersonRepository listUser = new PersonRepository();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            IEnumerable<Person> data = listUser.GetAll();

            return View(data);
        }

        public async Task<IActionResult> Supprimer(int id)
        {
            /*var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }*/

            return View();
        }

        [HttpPost, ActionName("Supprimer")]
        public async Task<IActionResult> ConfirmerSupprimer(int id)
        {
            /*var person = await _context.Person.FindAsync(id);
            _context.Produits.Remove(produit);
            await _context.SaveChangesAsync();*/
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
