using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Acceso_a_datos;

namespace Logica
{
   public class LogicaOp
    {
        List<Persona> listPer = new List<Persona>();
        Persona per = new Persona();
        OperacionesPersonas Opersona = new OperacionesPersonas();
        OperacionesTelefonos Otelefono = new OperacionesTelefonos();
        OPPersona op = new OPPersona();
        
        public void Salvar()
        {
            foreach (Persona p  in listPer)
            {
                Opersona.Insertar(p);
            }
            //foreach (Telefono tel in per)
            //{

            //}
        }
        
    }
}
