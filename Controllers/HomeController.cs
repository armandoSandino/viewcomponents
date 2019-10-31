using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;




namespace ViewComponents.Controllers
{
    public class HomeController : Controller
    {
        DbContext contexto = new DbContext();

        public IActionResult Index( int? id = 0 )
        {
            ViewBag.ID = id;
                
            var cli = contexto.lista_casas;
            return View( cli );
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
