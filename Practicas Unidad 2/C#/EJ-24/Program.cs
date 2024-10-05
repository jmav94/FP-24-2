using EJ_24;

Promedio miPromedio = new Promedio();

miPromedio.C1 = 70;
miPromedio.C2 = 80;
miPromedio.C3 = 90;

Console.WriteLine(miPromedio.Mensaje());

miPromedio.C1 = 70;
miPromedio.C2 = 71;
miPromedio.C3 = 76;

Console.WriteLine(miPromedio.Mensaje());

miPromedio.C1 = 100;
miPromedio.C2 = 100;
miPromedio.C3 = 100;

Console.WriteLine(miPromedio.Mensaje());

miPromedio.C1 = 90;
miPromedio.C2 = 98;
miPromedio.C3 = 96;

Console.WriteLine(miPromedio.Mensaje());