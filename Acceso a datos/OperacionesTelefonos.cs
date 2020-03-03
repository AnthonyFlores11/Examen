using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Acceso_a_datos
{
    public class OperacionesTelefonos : IOperaciones<Telefono>
    {
        private ConeccionBD coneccion = new ConeccionBD();
        public Telefono Buscar(int id)
        {
            string query = string.Format("Select * FROM dbo.Telefono WHERE id={0}", id);
            SqlDataReader resultado = coneccion.ConexionSQLQuery(query);
            if (resultado != null)
            {
                while (resultado.NextResult())
                {
                    return new Celular( resultado.GetString(1), resultado.GetBoolean(id), resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetString(4));
                }
            }
            return null;
        }

        public Telefono Buscar(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<Telefono> BuscarTodo()
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Telefono item)
        {
            string query = string.Format ("DELETE FROM dbo.Telefono");
            coneccion.ConexionSQLNoQuery(query);
        }

        public void Insertar(Telefono item)
        {
            string query = string.Format ("INSERT INTO dbo.Telefono");
            coneccion.ConexionSQLNoQuery(query);
        }

        public void Modificar(Telefono item)
        {
            throw new NotImplementedException();
        }

        public List<Telefono> Mostrar()
        {
            throw new NotImplementedException();
        }

        public List<Telefono> MostrarTodo()
        {
            throw new NotImplementedException();
        }
    }
}
