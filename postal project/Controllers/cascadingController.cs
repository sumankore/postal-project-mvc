using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using postal_project.Data;
using postal_project.Models;

namespace postal_project.Controllers
{
    public class cascadingController : Controller
    {
        public postal_projectContext db = new postal_projectContext();
        // GET: cascading
        public ActionResult Index()
        {
            ViewBag.CountryList = new SelectList(Getcountries(), "CountryID", "Name");
            return View();
        }
        public List<country> Getcountries()
        {
            List<country> Countries = db.countries.ToList();
            return Countries;
        }
    }
}