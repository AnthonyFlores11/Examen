using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract class Telefono
    {
        protected int id;
        protected int numero;
        protected string descripcion;

        protected Telefono(int id, int numero, string descripcion)
        {
            id = id;
            numero = numero;
            descripcion = descripcion;
        }

        public virtual void DatosTelefono()
        {
            Console.WriteLine("Muestra los datos del telefono");
        }

        public abstract void Telefonos();
        }
    }

