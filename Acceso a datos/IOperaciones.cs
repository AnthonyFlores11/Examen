using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_datos
{
  public  interface IOperaciones<T>
    {
        void Insertar(T item);
        T Buscar(int id);
        T Buscar(string nombre);
        List<T> BuscarTodo();
        void Modificar(T item);
        void Eliminar(T item);
        
    }
}
