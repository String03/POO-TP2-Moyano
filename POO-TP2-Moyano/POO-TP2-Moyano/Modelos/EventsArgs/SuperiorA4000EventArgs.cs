using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP2_Moyano.Modelos.EventsArgs
{
   public class SuperiorA4000EventArgs : EventArgs
    {
        public SuperiorA4000EventArgs(string pLegajo, string pDescripcion, Cliente cliente)
        {
            Legajo = pLegajo;
            Descripcion = pDescripcion;
            Cliente = cliente;

        }
        public string Legajo { get; set; }
        public string Descripcion { get; set; }
        public Cliente Cliente { get; set; }
    }
}
