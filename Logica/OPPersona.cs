using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_a_datos;

namespace Logica
{
   public class OPPersona : IOperacionesEntidades<Persona>
    {
        //Crear una nueva lista y empezar a implementarla
        List<Persona> listPer = new List<Persona>();
        public Persona Buscar(int id)
        {
            foreach (Persona p in listPer)
            {
                if(id == p.Id1)
                {
                    Console.WriteLine("La persona encontrada es" + p.Nombre1, p.Apellidos1, p.Email1, p.Cedula1);
                }
                else
                {
                    Console.WriteLine("No fue encontrada la persona");
                }
                
            }
            return null;
                
        }

        public Persona Buscar(string nombre)
        {
            foreach (Persona p in listPer)
            {
                if (nombre.Equals(p.Nombre1))
                {
                    Console.WriteLine("La persona encontrada es" + p.Nombre1, p.Apellidos1, p.Email1, p.Cedula1);
                }
                else
                {
                    Console.WriteLine("No fue encontrada la persona");
                }
            }
            return null;
        }

        public void Eliminar(Persona item)
        {
            try
            {
                listPer.Remove(item);
            }
            catch (Exception)
            {

                Console.WriteLine("Error al eliminar");
            }
            
        }

        public void Insertar(Persona item)
        {
            try
            {
                listPer.Add(item);
            }
            catch (Exception)
            {

               Console.WriteLine("Algo salio mal");
            }
            
        }

        public List<Persona> Mostrar()
        {
            return listPer;
            
            
        }

        public List<Persona> MostrarTodo()
        {
            List<Persona> per = new List<Persona>();
            try
            {
                if(listPer.Count == 0)
                {
                    Console.WriteLine("Lista Vacia");
                }
                else
                {
                    foreach (Persona p in listPer)
                    {
                        per.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error" + ex.Message);
            }
            return listPer;
        }
        
    }
}
