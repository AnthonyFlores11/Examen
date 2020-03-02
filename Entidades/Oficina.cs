using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Oficina : Telefono
    {
        protected string empresa;
        protected string horario;

        public Oficina(string empresa, string horario, int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
            this.empresa = empresa;
            this.horario = horario;
        }

        public override void Telefonos()
        {
           // Console.WriteLine("La informacion del telefono es:", id, numero, descripcion);
        }
    }
}
