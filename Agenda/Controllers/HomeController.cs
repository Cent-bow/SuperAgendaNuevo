using Agenda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly dbContactosContext _db;

        public HomeController(ILogger<HomeController> logger, dbContactosContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
           
            var contactos = _db.Contactos;
            return View(contactos);
        }





        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar (Contacto Input)
        {
            if (ModelState.IsValid)
            {
                _db.Contactos.Add (Input);
                _db.SaveChanges();
            }
            return View(Input);
        }

        public IActionResult Modificar (int id)
        {
            var output = _db.Contactos.Find(id);
            return View(output);
        }

        [HttpPost]

        public IActionResult Modificar (Contacto input)
        {

            if (ModelState.IsValid)
            {
                _db.Entry(input).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _db.SaveChanges();
            }

            return View(input);
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
