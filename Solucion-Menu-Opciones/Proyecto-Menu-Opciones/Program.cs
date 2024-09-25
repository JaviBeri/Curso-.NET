// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Mostrar la fecha y hora actuales");
            Console.WriteLine("2. Sumar dos números");
            Console.WriteLine("3. Contar hasta un número");
            Console.WriteLine("4. Salir");

            Console.WriteLine("Selecciona una opción");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has seleccionado la opción 1");
                    DateTime now = DateTime.Now;
                    Console.WriteLine("Fecha y hora actuales: " + now);
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado la opción 2");
                    Console.WriteLine("Introduce el primer número: ");
                    int numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce el segundo número: ");
                    int numero2 = Convert.ToInt32(Console.ReadLine());
                    int suma = numero1 + numero2;
                    Console.WriteLine("La suma de los números es: " + suma);
                    break;
                case 3:
                    Console.WriteLine("Has seleccionado la opción 3");
                    Console.WriteLine("Elige hasta qué número quieres contar");
                    int contar = Convert.ToInt32(Console.ReadLine());
                    int total = 0;
                    while (total < contar)
                    {
                        total++;
                        Console.WriteLine("Número " + total);
                    }
                    break;
                case 4:
                    Console.WriteLine("Has seleccionado la opción 4");
                    Console.WriteLine("Hasta pronto!!");
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor selecciona otra.");
                    break;
            }
        } while (opcion != 4);
    }
}

