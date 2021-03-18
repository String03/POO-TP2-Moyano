using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP2_Moyano.Modelos
{
    public abstract class Cliente
    {
        List<Contenedor> _Contenedores;

        public Cliente()
        {
            _Contenedores = new List<Contenedor>();
        }
        public Cliente(string pLegajo) : this()
        { Legajo = pLegajo; }


        public Contenedor[] Cuentas { get { return _Contenedores.ToArray(); } }

        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string RazonSocial { get; set; }



        public List<Contenedor> Contenedores { get { return this._Contenedores; } }

        public override string ToString()
        {
            return this.Legajo;
        }
    }
}
