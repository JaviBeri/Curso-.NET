using System.Security.Cryptography.X509Certificates;

namespace Proyecto_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suma sumarnumero = new Suma();
            Resta restarnumero = new Resta();
            Multiplicar multiplicarnumero = new Multiplicar();
            Division dividirnumero = new Division();
                        
            bool salir = false;
            string? opcion = "";
            

            while (!salir)
            {
                Console.WriteLine("Selecciona la operación que quieres realizar:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                opcion = Console.ReadLine(); 

                switch (opcion)
                {
                    case "1":
                        double resultadosuma = sumarnumero.Sumar();
                        Console.WriteLine("El resultado de la suma es: " + resultadosuma);
                        break;

                    case "2":
                        double resultadoresta = restarnumero.Restar();
                        Console.WriteLine("El resultado de la resta es: " + resultadoresta);
                        break;

                    case "3":
                        double resultadomulti = multiplicarnumero.Multiplicacion();
                        Console.WriteLine("El resultado de la multiplicación es: " + resultadomulti);
                        break;

                    case "4":
                        double resultadodivision = dividirnumero.Dividir();
                        Console.WriteLine("El resultado de la división es: " + resultadodivision);
                        break;                    
                    case "5":
                        salir = true;
                        Console.WriteLine("Hasta pronto!!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                                               
            }
                       
        }
        
    }
}
