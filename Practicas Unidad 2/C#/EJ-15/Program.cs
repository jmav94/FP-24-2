using EJ_15;

Promedio miPromedio = new Promedio();

miPromedio.A = 1;
miPromedio.B = 2;
miPromedio.C = 3;
miPromedio.D = 4;
miPromedio.E = 5;

Console.WriteLine($"El promedio de los numeros ingresados ignorando el mayor y el menor es de: {miPromedio.Calcular().ToString("N2")}");

Console.Write("\nCaptura el valor de a: ");
miPromedio.A = int.Parse(Console.ReadLine());
Console.Write("Captura el valor de b: ");
miPromedio.B = int.Parse(Console.ReadLine());
Console.Write("Captura el valor de c: ");
miPromedio.C = int.Parse(Console.ReadLine());
Console.Write("Captura el valor de d: ");
miPromedio.D = int.Parse(Console.ReadLine());
Console.Write("Captura el valor de e: ");
miPromedio.E = int.Parse(Console.ReadLine());

Console.WriteLine($"El promedio de los numeros capturados ignorando el mayor y el menor es de: {miPromedio.Calcular().ToString("N2")}");
