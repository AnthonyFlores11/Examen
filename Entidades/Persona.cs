﻿using System;
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


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }

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
        }
    }
}
