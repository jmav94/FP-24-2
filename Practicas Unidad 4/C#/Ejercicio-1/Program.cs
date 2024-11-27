internal class Program
{
    private static void Main(string[] args)
    {
        int[] miArreglo;
        int celda, tamano;

        Console.WriteLine("Captura el tamaño del arreglo:");
        tamano = int.Parse(Console.ReadLine());

        miArreglo = new int[tamano];

        for (celda = 0; celda < tamano; celda++)
        {
            Console.WriteLine($"Capture el valor de la celda en la posicion {celda}");
            miArreglo[celda] = int.Parse(Console.ReadLine());
        }

        quitarNegativos(ref miArreglo);

        Console.WriteLine("Valores del arreglo sin negativos");

        foreach (int numero in miArreglo)
        {
            Console.WriteLine(numero);
        }

    }
    private static void quitarNegativos(ref int[] unArreglo){
        for (int i = 0; i < unArreglo.Length; i++)
        {
            if (unArreglo[i] < 0)
            {
                unArreglo[i] = 0;
            }
        }
    }
}