using Ejercicio_Cajero_Automatico;

CuentaBancaria cuenta = new CuentaBancaria();
        int opcion = 0;
        double importe;

        while (opcion != 4)
        {
            Console.WriteLine("\nMenú de Cajero:");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Consultar Saldo");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese monto a depositar: ");
                    importe = double.Parse(Console.ReadLine());
                    cuenta.Depositar(importe);
                    break;
                case 2:
                    Console.Write("Ingrese monto a retirar: ");
                    importe = double.Parse(Console.ReadLine());
                    cuenta.Retirar(importe);
                    break;
                case 3:
                    cuenta.MostrarSaldo();
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar el cajero.");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }