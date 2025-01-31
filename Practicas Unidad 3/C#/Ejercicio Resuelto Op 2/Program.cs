using Ejercicio_Resuelto_Op_2;

Estudiante miEstudiante, estudianteMayor;
int i;
estudianteMayor = new Estudiante();

for(i = 1; i<= 3; i++)
{
    miEstudiante = new Estudiante();
    do
    {
        Console.Write("Nombre del estudiante: ");
        miEstudiante.Nombre = Console.ReadLine();
    } while (miEstudiante.Nombre == "");

    do
    {
        Console.Write("Calificación del estudiante: ");
        miEstudiante.Calificacion = int.Parse(Console.ReadLine());
    } while (miEstudiante.Calificacion < 0 || miEstudiante.Calificacion > 100);

    if (i == 1){
        estudianteMayor = miEstudiante;
    } else {
        if (miEstudiante.Calificacion > estudianteMayor.Calificacion){
            estudianteMayor = miEstudiante;
        }
    }
}Console.WriteLine("Estudiante con mayor calificación: " + estudianteMayor.Nombre + " con una calificacion de: " + estudianteMayor.Calificacion + " puntos.");