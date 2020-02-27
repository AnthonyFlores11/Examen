using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_a_datos;
using System.Data.SqlClient;

namespace Acceso_a_datos
{
     
    public class OperacionesPersona : IOperaciones<Persona>
    {
        private ConeccionBD coneccion = new ConeccionBD();
        public Persona Buscar(int id)
        {
            string query = string.Format("Select * FROM Persona WHERE id={0}", id);
            SqlDataReader resultado = coneccion.ConexionSQLQuery(query);
            if(resultado != null)
            {
                while (resultado.NextResult())
                {
                    return new Persona(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4));
                }
            }
            return null;
            
        }

        public List<Persona> BuscarTodo()
        {
            string query = "SELECT * FROM Persona";
            List<Persona> persona = new List<Persona>();
            SqlDataReader resultado = coneccion.ConexionSQLQuery(query);
            if (resultado != null)
            {
                while (resultado.NextResult())
                {
                    persona.Add(new Persona(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4)));
                }
            }
            return null;

        }

        public void Eliminar(Persona item)
        {
            string query = "DELETE FROM dbo.Persona VALUES(" + item.Id + " , " + item.Nombre + "," + item.Apellidos + ")";
            SqlDataReader resultado = coneccion.ConexionSQLQuery(query);
        }

        public void Insertar(Persona item)
        {
            string query = "INSERT INTO dbo.Persona VALUES("+ item.Id +" , "+ item.Nombre + ","+ item.Apellidos +")";
            SqlDataReader resultado = coneccion.ConexionSQLQuery(query);
        }

        public void Modificar(Persona item)
        {
            string query = "UPDATE dbo.Persona VALUES(" + item.Id + " , " + item.Nombre + "," + item.Apellidos + ")";
            SqlDataReader resultado = coneccion.ConexionSQLQuery(query);
        }
    }
}
