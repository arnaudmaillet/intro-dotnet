using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataProvider;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private PersonRepository listUser = new PersonRepository();

        public ActionResult Index()
        {
            IEnumerable<Person> tableOfPeople = listUser.GetAll();
            return View(tableOfPeople);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}