using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP2_Moyano.Modelos
{
   public class ContenedorA : Contenedor
    {
        private object p;





        public ContenedorA(string pId, string pDescripcion, DateTime pFechaingreso, decimal pPeso)
           : base(pId, pDescripcion, pFechaingreso, pPeso) { }
    }
}
