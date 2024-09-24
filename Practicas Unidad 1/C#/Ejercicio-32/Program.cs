// See https://aka.ms/new-console-template for more information
using Ejercicio_32;

Vehiculo miVehiculo = new Vehiculo();

Console.WriteLine("Captura el costo del vehiculo");
miVehiculo.Costo = double.Parse(Console.ReadLine());
Console.WriteLine($"El costo final del vehiculo es de {miVehiculo.CalcularCostoFinal()}");
