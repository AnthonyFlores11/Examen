using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular : Telefono
    {
      protected  string compañia;
       protected Boolean roaming = true;

        public Celular(string compañia, bool roaming, int id, int numero, string descripcion) : base(id, numero, descripcion)
        {
            this.compañia = compañia;
            this.roaming = roaming;
        }

        public override void Telefonos()
        {
            Console.WriteLine("La informacion del telefono es:", id, numero, descripcion);
        }
    }

      
    
}

