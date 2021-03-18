using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP2_Moyano.Modelos
{
   public class Persona : Cliente
    {
        public Persona(string pLegajo, string pNombre, string pApellido) : base(pLegajo)
        {
            Nombre = pNombre;
            Apellido = pApellido;

        }
    }
}
