using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Ejemplo_Clase
{
    public class Calculadora
    {
        // Método que suma dos números
        public double   Sumar(double num1, double num2)
        { 
            return num1 + num2; 
        }

        // Método que resta dos números
        public double Restar(double rest1, double rest2)
        {
            return rest1 - rest2;
        }

        // Método que divide dos números
        public double Dividir(double div1, double div2)
        {
            if (div2 == 0)
            {
                MostrarMensajes("No se puede dividir por cero");
                return 0;
            }
            return div1 / div2;
        }

        // Método que multiplica dos números
        public double Multi(double mul1, double mul2)
        {
            return mul1 * mul2;
        }
        
        // Método que muestra un mensaje por pantalla
        public void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
