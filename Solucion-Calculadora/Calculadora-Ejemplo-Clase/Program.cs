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
    Console.WriteLine("5. Resto de la división");
    Console.WriteLine("6. Guardar en memoria");
    Console.WriteLine("9. Salir");
    Console.WriteLine("Selecciona una opción: ");
    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        // Suma de dos números
        case "1":
            Sumar(calculadora);
            break;

        // Resta de dos números
        case "2":
            Restar(calculadora);
            break;

        // Multiplicación de dos números
        case "3":
            Multiplicar(calculadora);
            break;

        // División de dos números
        case "4":
            Dividir(calculadora);
            break;

        // Calcular el resto de la división
        case "5":
            RestoDivision(calculadora);
            break;

        case "6":
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

static void Sumar(Calculadora calculadora)
{
    Console.WriteLine("Introduce el primer número: ");
    double num1 = calculadora.ObtenerNumeroConsola();
    Console.WriteLine("Introduce el segundo número: ");
    double num2 = calculadora.ObtenerNumeroConsola();
    double suma = calculadora.Sumar(num1, num2);
    calculadora.MostrarMensajes($"El resultado de la suma es: {suma}");
}

static void Restar(Calculadora calculadora)
{
    double num1, num2;
    PedirNumeros(calculadora, out num1, out num2);
    double resta = calculadora.Restar(num1, num2);
    calculadora.MostrarMensajes($"El resultado de la resta es: {resta}");
}

static void Multiplicar(Calculadora calculadora)
{
    double num1, num2;
    PedirNumeros(calculadora, out num1, out num2);
    double multi = calculadora.Multi(num1, num2);
    calculadora.MostrarMensajes($"El resultado de la resta es: {multi}");
}

static void Dividir(Calculadora calculadora)
{
    double num1, num2;
    PedirNumeros(calculadora, out num1, out num2);
    double divid = calculadora.Dividir(num1, num2);
    calculadora.MostrarMensajes($"El resultado de la resta es: {divid}");
}

static void RestoDivision(Calculadora calculadora)
{
    double num1, num2;
    PedirNumeros(calculadora, out num1, out num2);
    double resto = calculadora.Resto(num1, num2);
    calculadora.MostrarMensajes($"El resultado de la resta es: {resto}");
}

static void PedirNumeros(Calculadora calculadora, out double num1, out double num2)
{
    Console.WriteLine("Introduce el primer número: ");
    num1 = calculadora.ObtenerNumeroConsola();
    Console.WriteLine("Introduce el segundo número: ");
    num2 = calculadora.ObtenerNumeroConsola();
}