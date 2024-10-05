using EJ_5;

PagoMensual miPagoMensual = new PagoMensual();

miPagoMensual.Nombre = "Juan";
miPagoMensual.AutosVendidos = 12;

double sueldoNeto = miPagoMensual.CalcularSBruto()-miPagoMensual.CalcularImpuesto();
Console.WriteLine($"{miPagoMensual.Nombre}\n Sueldo Bruto : ${miPagoMensual.CalcularSBruto()}\n Impuesto: ${miPagoMensual.CalcularImpuesto()}\n Sueldo Neto: ${sueldoNeto}\n");

miPagoMensual.Nombre = "Rodrigo";
miPagoMensual.AutosVendidos = 18;

sueldoNeto = miPagoMensual.CalcularSBruto()-miPagoMensual.CalcularImpuesto();

Console.WriteLine($"{miPagoMensual.Nombre}\n Sueldo Bruto : ${miPagoMensual.CalcularSBruto()}\n Impuesto: ${miPagoMensual.CalcularImpuesto()}\n Sueldo Neto: ${sueldoNeto}\n");

miPagoMensual.Nombre = "Daniel";
miPagoMensual.AutosVendidos = 15;

sueldoNeto = miPagoMensual.CalcularSBruto()-miPagoMensual.CalcularImpuesto();

Console.WriteLine($"{miPagoMensual.Nombre}\n Sueldo Bruto : ${miPagoMensual.CalcularSBruto()}\n Impuesto: ${miPagoMensual.CalcularImpuesto()}\n Sueldo Neto: ${sueldoNeto}\n");

Console.WriteLine("Capture el nombre del vendedor:");
miPagoMensual.Nombre = Console.ReadLine();
Console.WriteLine("Capture la cantidad de autos vendidos por el vendedor:");
miPagoMensual.AutosVendidos = int.Parse(Console.ReadLine());

sueldoNeto = miPagoMensual.CalcularSBruto()-miPagoMensual.CalcularImpuesto();
Console.WriteLine($"\n{miPagoMensual.Nombre}\n Sueldo Bruto : ${miPagoMensual.CalcularSBruto()}\n Impuesto: ${miPagoMensual.CalcularImpuesto()}\n Sueldo Neto: ${sueldoNeto}\n");
