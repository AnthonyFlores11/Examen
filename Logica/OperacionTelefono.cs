using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
   public class OperacionTelefono: IOperacionesEntidades<Telefono>
    {
        List<Telefono> listTelefono = new List<Telefono>();
        public void Insertar(Telefono item)
        {
            try
            {
                listTelefono.Add(item);
            }
            catch (Exception)
            {

                Console.WriteLine("Ocurrio un error al insertar");
            }
        }

        public Telefono Buscar(int id)
        {
            foreach (Telefono tel in listTelefono)
            {
                if (id == tel.Id)
                {
                    Console.WriteLine("El telefono encontrado es" + tel.Id, tel.Numero);
                }
                else
                {
                    Console.WriteLine("Telelfono no encontrado");
                }

            }
            return null;
        }

        public Telefono Buscar(string nombre)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Telefono item)
        {
            try
            {
                listTelefono.Remove(item);
            }
            catch (Exception)
            {

                Console.WriteLine("Error al eliminar telefono");
            }
        }

        public List<Telefono> MostrarTodo()
        {
            throw new NotImplementedException();
        }

        public List<Telefono> Mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
