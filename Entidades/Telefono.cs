using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public abstract class Telefono
    {
        private int id;
        private int numero;
        private string descripcion;

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

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

