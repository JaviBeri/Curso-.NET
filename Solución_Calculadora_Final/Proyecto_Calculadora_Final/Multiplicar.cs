namespace Proyecto_Calculadora
{
    public class Multiplicar
    {
        public double Multiplicacion()
        {
            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return num1 * num2;
        }
    }
}