using EJ_9;

AnioNacimiento miAnioNacimiento = new AnioNacimiento();

miAnioNacimiento.Anio = 2020;

string bisiesto ;
//miAnioNacimiento.DeterminarBisiesto() == true ? "bisiesto" : "no bisiesto";

if (miAnioNacimiento.DeterminarBisiesto() == true)
{
    bisiesto = "bisiesto";
}
else bisiesto = "no bisiesto";
    

Console.WriteLine($"Tu año de nacimiento es un año {bisiesto}");

Console.WriteLine("Capture su año de nacimiento: ");
miAnioNacimiento.Anio = int.Parse(Console.ReadLine());

string bisiesto1 = miAnioNacimiento.DeterminarBisiesto() ? "bisiesto" : "no bisiesto";

Console.WriteLine($"Tu año de nacimiento es un año {bisiesto1}");