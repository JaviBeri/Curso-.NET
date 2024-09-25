// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejemplo while");

// Intentamos averiguar la contraseña 
string contraseña = "1234";
string contraseñaIntroducida = "";

int intentos = 0;

Console.WriteLine("Adivina la contraseña, tienes 3 intentos");

while (contraseñaIntroducida != contraseña)
{
    intentos++;
    Console.WriteLine("Intento " + intentos);
    Console.WriteLine("Introduce la contraseña:");
    contraseñaIntroducida = Console.ReadLine();
    
    if (intentos >= 3)
    {
        Console.WriteLine("¡Has superado el número de intentos");
        break;
    }
}
if (contraseñaIntroducida == contraseña)
{
    Console.WriteLine("¡Contraseña correcta!");
}
