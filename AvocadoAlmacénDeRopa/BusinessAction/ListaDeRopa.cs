using AvocadoAlmacénDeRopa.BusinessMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AvocadoAlmacénDeRopa.BusinessAction
{
    public class ListaDeRopa
    {
        public static RopaRespuesta GetAllRopa()
        {
            var ropa = new List<Ropa>()
            {
                new Ropa()
                {
                    TipoDeRopa= "Pantalón"
                },
                new Ropa()
                {
                    TipoDeRopa= "Camiseta"
                },
                new Ropa()
                {
                    TipoDeRopa= "Falda"
                },
                new Ropa()
                {
                    TipoDeRopa= "Zapatos"
                },
                new Ropa()
                {
                    TipoDeRopa= "Hoddies"
                },



            };

            return new RopaRespuesta ()
            {
                respuestaDeRopa = ropa
            };
        }
    }
}