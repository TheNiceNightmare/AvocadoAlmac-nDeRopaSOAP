using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvocadoAlmacénDeRopa.BusinessMessage
{
    public class RopaRespuesta
    {
        public List<Ropa> respuestaDeRopa { get; set; }

        public bool ActionResult { get; set; }

        public string Error { get; set; }
    }
}