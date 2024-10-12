using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Calculadora
{
    public class Division
    {
        public double Dividir()
        {
            Console.WriteLine("Introduce el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            while (num2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0, introduce otro número");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
                
            double resultado = num1 / num2;
            return resultado;   
        }
    }
}
