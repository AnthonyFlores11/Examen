using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona 
    {
       private int id;
        private string nombre;
        private string email;
        private string cedula;
        private string apellidos;
        private List<Telefono> listTelefono;
        

        
        
        public int Id1 { get => id; set => id = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Email1 { get => email; set => email = value; }
        public string Cedula1 { get => cedula; set => cedula = value; }
        public string Apellidos1 { get => apellidos; set => apellidos = value; }

        public Persona()
        {

        }

        public Persona(int id, string nombre, string email, string cedula, string apellidos)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.cedula = cedula;
            this.apellidos = apellidos;
            this.listTelefono = new List<Telefono>();
        }

        
    }
}
