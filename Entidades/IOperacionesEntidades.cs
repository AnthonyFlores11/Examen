using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public interface IOperacionesEntidades<T>
    {
        void Insertar(T item);
        T Buscar(int id);
        T Buscar(string nombre);
        
        void Eliminar(T item);
        List<T> MostrarTodo();
        List<T> Mostrar();
    }
}
