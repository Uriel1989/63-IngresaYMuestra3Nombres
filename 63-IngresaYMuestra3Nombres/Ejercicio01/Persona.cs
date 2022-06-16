using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Hablar()
        {
            return "Hola mi nombre es " + " " + this.Nombre + " " + this.Apellido;
        }
    }
}
