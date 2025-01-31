using EJ_26;

PolizaSeguro miPS = new PolizaSeguro();
miPS.Nombre = "Juan";
miPS.Edad = 25;
miPS.ValorVehiculo = 10000;
miPS.Modelo = 95;
miPS.NumAccidentes = 5;

Console.WriteLine("Nombre: " + miPS.Nombre + "El costo de tu poliza es de: " + miPS.C());