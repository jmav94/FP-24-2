namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración y creación de un objeto
            TemperaturaGradosFarenheit miTemperaturaGradosFarenheit = 
            new TemperaturaGradosFarenheit();
            // Captura la temperatura en °F
            Console.Write("Teclee la temperatura en grados farenheit: "); 
            miTemperaturaGradosFarenheit.GradosFarenheit = 
            double.Parse(Console.ReadLine());

            // Invoca el método para hacer la conversión e imprime el resultado
            Console.Write("La temperatura en °C = " +
             miTemperaturaGradosFarenheit.ConvertirAGradosCentigrados().ToString("N2"));

            Console.Read();
        }
    }
}