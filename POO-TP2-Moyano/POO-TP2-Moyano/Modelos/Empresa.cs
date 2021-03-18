using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP2_Moyano.Modelos
{
   public class Empresa : Cliente
    {
        public Empresa(string pLegajo, string pRazonSocial) : base(pLegajo)
        {
            RazonSocial = pRazonSocial;
        }
    }
}
