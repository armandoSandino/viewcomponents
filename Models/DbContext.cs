
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ViewComponents.Models
{
    public class DbContext
    {
        public List<Casa> lista_casas{set;get;}
        public DbContext(){
            lista_casas = new List<Casa>();
            volcar_datos();
        }
        private void volcar_datos(){
            for(int i =0 ; i < 10; i++ ){
                Casa ca = new Casa();
                ca.Id=(i+1);
                ca.Ciudad = "Matagalpa";
                ca.Ubicacion ="Calle "+ (i+1);
                ca.Detalle = new DetalleCasa( (5000+i+1), (i+1), (i+1) );
                lista_casas.Add( ca );
            }
        }
    }
}