using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hogar : Telefono

        
    {
        protected string provincia;
        protected string ciudad;

        public Hogar(string provincia, string ciudad, int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
            this.provincia = provincia;
            this.ciudad = ciudad;
        }

        public override void Telefonos()
        {
          //  Console.WriteLine("La informacion del telefono es:", id, numero, descripcion);
        }
    }
}
