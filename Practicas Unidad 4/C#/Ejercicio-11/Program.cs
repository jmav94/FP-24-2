using Ejercicio_11;

    int opcion, celda;
    double promedio, ventaMayor;
    int mesVentaMenor;
    Venta miVenta = new Venta();

    for (celda = 0; celda < 12; celda++)
    {
        Console.WriteLine($"Capture la venta del mes {celda + 1}");
        miVenta[celda] = double.Parse(Console.ReadLine());
    }

    do
    {
        Console.WriteLine("Seleccione la funcion que desea ejecutar:\n 1- Calcular Promedio \n 2- Calcular Venta Mayor \n 3 - Mes con venta menor \n 0 - Salir");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1 : promedio = miVenta.CalcularPromedio();
                     Console.WriteLine($"El promedio de ventas es de: {promedio}"); break;
            case 2 : ventaMayor = miVenta.CalcularVentaMayor();
                     Console.WriteLine($"El venta mayor es de: {ventaMayor}"); break;
            case 3 : mesVentaMenor = miVenta.CalcularMesVentaMenor();
                     Console.WriteLine($"El mes con venta menor es: {mesVentaMenor}"); break;
            default : Console.WriteLine("Seleccione una opcion correcta."); break;
        }
    } while (opcion != 0);
