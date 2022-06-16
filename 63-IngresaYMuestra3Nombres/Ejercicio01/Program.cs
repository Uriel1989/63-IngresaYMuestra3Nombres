using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo de dato Objeto = palabra reservada constructor()

            List<Persona> ListaPersonas = new List<Persona>();


            for (int i = 0; i<3; i++)
            {
                Persona p1 = new Persona();

                Console.WriteLine("ingrese un nombre para mostrar:");

                p1.Nombre = Console.ReadLine();

                Console.WriteLine("ahora ingrese el apellido:");
                p1.Apellido = Console.ReadLine();

                Console.Clear();

                ListaPersonas.Add(p1);
            }

            for (int i=0; i<ListaPersonas.Count; i++)
            {
                Persona j = ListaPersonas[i];
                Console.WriteLine(j.Hablar());
            }
            Console.ReadKey();
        }
    }
}
