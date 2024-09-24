// See https://aka.ms/new-console-template for more information
Console.Write("Introduce un número para que otro jugador lo adivine: ");
int numeroAdivinar = int.Parse(Console.ReadLine());

// Limpiar la consola para que el segundo jugador no vea el número
Console.Clear();

// Dar tres oportunidades para adivinar el número
for (int i = 3; i != 0; i--)
{
    Console.Write("Adivina el número, tienes " + i + " intentos: ");
    int intento = int.Parse(Console.ReadLine());

    if (intento == numeroAdivinar)
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número.");
        return;
    }
    else
    {
        if (intento < numeroAdivinar)
        {
            Console.WriteLine("Menor!!");
            Console.WriteLine("Intentalo de nuevo!! ");
        }
        else
        {
            Console.WriteLine("Mayor!!");
            Console.WriteLine("Intentalo de nuevo!! ");
        }
    }

}

Console.WriteLine("Lo siento, no has adivinado el número.");
