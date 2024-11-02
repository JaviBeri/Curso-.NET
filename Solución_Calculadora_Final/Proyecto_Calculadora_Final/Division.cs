namespace Proyecto_Calculadora
{
    public class Division
    {
        public double Dividir()
        {
            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Error: División por cero.");
                return double.NaN; // Manejar la división por cero
            }
            return num1 / num2;
        }
    }
}