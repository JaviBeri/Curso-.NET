using System;

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
            Guardar guardamemoria = new Guardar();
            Recuperar recuperamemoria = new Recuperar();

            bool salir = false;
            string? opcion = "";
            double ultimoresultado = 0;

            while (!salir)
            {
                Console.WriteLine("Selecciona la operación que quieres realizar:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Guardar en memoria");
                Console.WriteLine("6. Recuperar de memoria");
                Console.WriteLine("7. Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ultimoresultado = sumarnumero.Sumar();
                        Console.WriteLine("El resultado de la suma es: " + ultimoresultado);
                        break;

                    case "2":
                        ultimoresultado = restarnumero.Restar();
                        Console.WriteLine("El resultado de la resta es: " + ultimoresultado);
                        break;

                    case "3":
                        ultimoresultado = multiplicarnumero.Multiplicacion();
                        Console.WriteLine("El resultado de la multiplicación es: " + ultimoresultado);
                        break;

                    case "4":
                        ultimoresultado = dividirnumero.Dividir();
                        if (ultimoresultado != double.NaN)
                        {
                            Console.WriteLine("El resultado de la división es: " + ultimoresultado);
                        }
                        break;

                    case "5":
                        // Guardar el último resultado de la operación
                        guardamemoria.GuardarResultado(ultimoresultado);
                        Console.WriteLine("Resultado guardado en memoria: " + ultimoresultado);
                        break;

                    case "6":
                        // Recuperar el resultado guardado de la memoria
                        double resultadoRecuperado = recuperamemoria.RecuperarResultado(guardamemoria);
                        Console.WriteLine("El resultado recuperado de la memoria es: " + resultadoRecuperado);

                        // Ejemplo de cómo usar el resultado recuperado en una nueva operación
                        Console.WriteLine("¿Deseas usar el resultado recuperado en una nueva operación? (s/n)");
                        string usarResultado = Console.ReadLine();

                        if (usarResultado?.ToLower() == "s")
                        {
                            Console.WriteLine("Selecciona la operación:");
                            Console.WriteLine("1. Sumar");
                            Console.WriteLine("2. Restar");
                            Console.WriteLine("3. Multiplicar");
                            Console.WriteLine("4. Dividir");
                            string? operacion = Console.ReadLine();

                            double nuevoResultado = 0;

                            switch (operacion)
                            {
                                case "1":
                                    nuevoResultado = resultadoRecuperado + sumarnumero.Sumar();
                                    Console.WriteLine("El nuevo resultado de la suma es: " + nuevoResultado);
                                    break;

                                case "2":
                                    nuevoResultado = resultadoRecuperado - restarnumero.Restar();
                                    Console.WriteLine("El nuevo resultado de la resta es: " + nuevoResultado);
                                    break;

                                case "3":
                                    nuevoResultado = resultadoRecuperado * multiplicarnumero.Multiplicacion();
                                    Console.WriteLine("El nuevo resultado de la multiplicación es: " + nuevoResultado);
                                    break;

                                case "4":
                                    double divisor = dividirnumero.Dividir();
                                    if (divisor != 0)
                                    {
                                        nuevoResultado = resultadoRecuperado / divisor;
                                        Console.WriteLine("El nuevo resultado de la división es: " + nuevoResultado);
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Opción no válida");
                                    break;
                            }
                        }
                        break;

                    case "7":
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