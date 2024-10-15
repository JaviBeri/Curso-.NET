
using ClasesAnimales;
using ClasesLibros;
using ClasesEmpleados;
using EjemploHerenciaProyecto;



//// Crear una serie de animales, basados en las clases Retriever, Terrier, HouseCat y Tiger
//var animals = new List<Animal>
//{
//    new Retriever("Buddy", 5),
//    new Terrier("Max", 3),
//    new HouseCat("Whiskers", 2),
//    new Tiger("Tony", 7)
//};
//// Mostrar informacion de los animales mediante un bucle foreach y Console.WriteLine
//foreach (Animal animal in animals)
//{
//    Console.WriteLine($"Nombre: {animal.Nombre}, Edad: {animal.Edad}");
//}

//// Crear una lista de Empleados , basados en las clases Administrative, Factory, MiddleMgmt y SeniorMgMt
//var employees = new List<Empleado>
//{
//    new Administrative("John", 5),
//    new Factory("Jane", 3),
//    new MiddleMgMt("Jim", 2),
//    new SeniorMgMt("Jill", 7),
//    new ExternalInCompany("Jorge", 10,"ACME Services","IT"),
//    new Subcontractor("Javier", 15,"ACME Services","ACME Management Version 1.0")
//};
//// Mostrar la información de los empleados mediante un bucle foreach 
//// y el metodo ToString que se ha sobrescrito en cada clase
//foreach (Empleado employee in employees)
//{
//    Console.WriteLine(employee.ToString());
//}

//// Crear una serie de libros basados en las clases Literature, Popular, History y Science
//var books = new List<Book>
//{
//    new Literature("The Great Gatsby", "F. Scott Fitzgerald",250),
//    new Popular("The Da Vinci Code", "Dan Brown",300),
//    new History("The Guns of August", "Barbara Tuchman",400),
//    new Science("A Brief History of Time", "Stephen Hawking",500)
//};

//// Mostrar la información de los libros mediante un bucle foreach y el método DisplayInfo
//foreach (Book book in books)
//{
//    book.DisplayInfo();
//}


// Crear un menu con dos opciones, 1-Crear Company y 2-Listar Companies
// Si se selecciona la opcion 1, se pedira el nombre de la empresa y se creara un objeto Company y se agrega a la lista de Companies
// Si se selecciona la opcion 2, se mostrara la lista de Companies
// Se debe crear una clase Company con un atributo Name y un metodo DisplayInfo que muestre el nombre de la empresa
// Se debe crear una lista de Companies para almacenar los objetos Company
// Se debe crear un bucle infinito que muestre el menu y permita seleccionar una opcion
// Se debe crear un metodo para mostrar el menu
// Se debe crear un metodo para crear una Company
// Se debe crear un metodo para listar las Companies


var menu = new Menu();
menu.MostrarMenu();