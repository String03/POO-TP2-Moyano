using POO_TP2_Moyano.Modelos.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP2_Moyano.Modelos
{
   public abstract class Contenedor
    {
        public Contenedor(string pId, string pDescripcion, DateTime pFechaingreso, decimal pPeso)
        { Id = pId; Descripcion = pDescripcion; Fechaingreso = pFechaingreso; Peso = pPeso; }

        protected decimal _peso;
        protected Cliente _cliente;

        public string Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fechaingreso { get; set; }
        public decimal Peso
        {
            get { return this._peso; }
            set
            {
                this._peso = value;
                if (value > 4000) { OcurreSuperiorA4000(new SuperiorA4000EventArgs(Id, Descripcion, _cliente)); }

            }
        }

        public void AsociarCliente(Cliente C)
        {
            this._cliente = C;

        }

        public Cliente ObtenerCliente()
        {
            return this._cliente;
        }

        public event EventHandler<SuperiorA4000EventArgs> SuperiorA4000;
        protected virtual void OcurreSuperiorA4000(SuperiorA4000EventArgs e)
        {
            EventHandler<SuperiorA4000EventArgs> handler = SuperiorA4000;
            if (handler != null) { handler(this, e); }
        }

    }
}
