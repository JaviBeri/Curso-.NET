using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Calculadora
{
    public class Resta
    {
        public double Restar()
        {
            Console.WriteLine("Introduce el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 - num2;
            return resultado;
        }
    }
}
