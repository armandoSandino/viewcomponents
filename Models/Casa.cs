
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ViewComponents.Models
{
    public class Casa {
        [HiddenInput]
        public int Id{set;get;}
        public String Ciudad{set;get;}
        public String Ubicacion{set;get;}
        public DetalleCasa Detalle{set;get;}
        public Casa(){
            this.Detalle = new DetalleCasa();
        }
    }
}