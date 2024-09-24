namespace Proyecto_Mayor_de_Edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa tu edad:");
            string introducido = Console.ReadLine();
            int edad;
            bool exito = int.TryParse(introducido, out edad);

            if (exito)
            {
                if (edad >= 18)
                {
                    Console.WriteLine("Eres mayor de edad");
                }
                else
                {
                    Console.WriteLine("Eres menor de edad");
                }
            }
            else
            {

                Console.WriteLine("Introduce una edad correcta");

            }

            if (edad <= 12)
            {
                Console.WriteLine("Eres un niños");

            }
            else
            {
                if (edad > 12 && edad < 18)
                {
                    Console.WriteLine("Eres un adolescente");

                }
                else
                {
                    if (edad >= 18 && edad < 65)
                    {
                        Console.WriteLine("Eres un adulto");
                    }
                    else
                    {
                        Console.WriteLine("Eres un jubilado");
                    }
                }
            }

        }
    }
}
