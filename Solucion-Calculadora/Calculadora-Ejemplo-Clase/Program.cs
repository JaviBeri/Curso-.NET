using Calculadora_Ejemplo_Clase;

// Crear una instancia de la calculadora
Calculadora calculadora = new Calculadora();

// Llamar al método Sumar de la calculadora
// double resultado = calculadora.Sumar(5, 10);

// Mostrar el resultado
// Console.WriteLine(resultado);

// Menú para la calculadora
bool salir = false;
while (!salir)
{
    
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Guardar en memoria");
    Console.WriteLine("9. Salir");
    Console.WriteLine("Selecciona una opción: ");
    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        // Suma de dos números
        case "1":
            Console.WriteLine("Introduce el primer número: ");
            double num1 = calculadora.ObtenerNumeroConsola();
            Console.WriteLine("Introduce el segundo número: ");
            double num2 = calculadora.ObtenerNumeroConsola(); 
            double suma = calculadora.Sumar(num1, num2);
            calculadora.MostrarMensajes($"El resultado de la suma es: {suma}");
            break;

        // Resta de dos números
        case "2":
            Console.WriteLine("Introduce el primer número: ");
            double rest1 = calculadora.ObtenerNumeroConsola();
            Console.WriteLine("Introduce el segundo número: ");
            double rest2 = calculadora.ObtenerNumeroConsola();
            double resta = calculadora.Restar(rest1, rest2);
            calculadora.MostrarMensajes($"El resultado de la resta es: {resta}");
            break;

        // Multiplicación de dos números
        case "3":
            Console.WriteLine("Introduce el primer número: ");
            double mul1 = calculadora.ObtenerNumeroConsola();
            Console.WriteLine("Introduce el segundo número: ");
            double mul2 = calculadora.ObtenerNumeroConsola();
            double multi = calculadora.Multi(mul1, mul2);
            calculadora.MostrarMensajes($"El resultado de la resta es: {multi}");
            break;

        // División de dos números
        case "4":
            Console.WriteLine("Introduce el primer número: ");
            double div1 = calculadora.ObtenerNumeroConsola();
            Console.WriteLine("Introduce el segundo número: ");
            double div2 = calculadora.ObtenerNumeroConsola();
            double divid = calculadora.Dividir(div1, div2);
            calculadora.MostrarMensajes($"El resultado de la resta es: {divid}");
            break;

        case "5":
            calculadora.GuardarEnMemoria();
            calculadora.MostrarMensajes($"El valor {calculadora.MemoriaCalculadora} se ha guardado");
            break;
            
        case "9":
            salir = true;
            calculadora.MostrarMensajes("Hasta pronto!!");
            break;

        default:
            calculadora.MostrarMensajes("Opción no válida, selecciona de nuevo: ");
            break;

    }
}
