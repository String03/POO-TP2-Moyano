using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP2_Moyano.Modelos
{
  public  class ContenedorB : Contenedor
    {
        public ContenedorB(string pId, string pDescripcion, DateTime pFechaingreso, decimal pPeso)
             : base(pId, pDescripcion, pFechaingreso, pPeso * (decimal)1.1)
        {


        }



    }
}
