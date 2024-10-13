using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases_Animales
{
    public class Animal
    {
        // Propiedad Nombre
        public string Nombre { get; set; }

        // Propiedad Edad
        public int Edad {  get; set; }

        // Constructor que admite dos parámetros, nombre y edad
        public Animal (string nombre, int edad)
        {  
            Nombre = nombre; 
            Edad = edad; 
        }
    }
}