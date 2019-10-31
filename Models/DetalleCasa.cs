
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ViewComponents.Models
{
    public class DetalleCasa{
        public long Dimensiones{set;get;}
        public int Cuartos{set;get;}
        public int Baños{set; get;}
        public DetalleCasa(){
        }
        public DetalleCasa(long dimen, int cuartos,int baños ){
            this.Dimensiones = dimen;
            this.Cuartos = cuartos;
            this.Baños = baños; 
        }

    }
}