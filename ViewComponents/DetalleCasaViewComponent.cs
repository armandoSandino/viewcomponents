using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using ViewComponents.Models;

namespace ViewComponents
{
    public class DetalleCasaViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke( int id )
        {
            DbContext con = new DbContext();
            var lista  = con.lista_casas;
            foreach (var item in lista )
            {
                if( item.Id == id ){
                ViewBag.loca_house = item.Ciudad;
                ViewBag.ID_CASA = id;
                return View( item.Detalle );
                }
                
            }            
            return View(null);
        }
    }
}