// See https://aka.ms/new-console-template for more information
using Ejercicio_22;

// Creacion del Objeto
Articulo miArticulo = new Articulo();

// Captura de los valores de los atributos por medio de las propiedades
Console.WriteLine("Captura el nombre del Articulo: ");
miArticulo.Nombre = Console.ReadLine();
Console.WriteLine("Captura el precio del Artculo");
miArticulo.Precio = double.Parse(Console.ReadLine());
Console.WriteLine("Capture la cantidad vendida del Articulo.");
miArticulo.CantidadVendida = int.Parse(Console.ReadLine());

// Impresion de Calculos
Console.WriteLine($"El IVA es de: {miArticulo.CalcularIVA()}");
Console.WriteLine($"El Descuento es de: {miArticulo.CalcularDescuento()}");
Console.WriteLine($"El Subtotal es de: {miArticulo.CalcularSubtotal()}");
Console.WriteLine($"El Total de la compra es de: {miArticulo.CalcularSubtotal()+miArticulo.CalcularIVA()+miArticulo.CalcularDescuento()}");


