namespace Proyecto_Calculadora;
 public class Resta
{
    public double Restar()
    {
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        return num1 - num2;
    }
}