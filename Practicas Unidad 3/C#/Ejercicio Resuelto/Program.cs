using Ejercicio_Resuelto;

Estudiante miEstudiante;
int i, calificacionMayor;
string nombreEstudiante;

nombreEstudiante = "";
calificacionMayor = 0;

for(i = 1; i <= 3; i++){
    miEstudiante = new Estudiante();

    do{
        Console.WriteLine("Teclee el nombre del estudiante");
        miEstudiante.Nombre = Console.ReadLine();
    }while(miEstudiante.Nombre == "");

    do{
        Console.WriteLine("Teclee la calificacion");
        miEstudiante.Calificacion = int.Parse(Console.ReadLine());
    }while(miEstudiante.Calificacion < 0 || miEstudiante.Calificacion > 100);

    if(i == 1){
        calificacionMayor = miEstudiante.Calificacion;
        nombreEstudiante = miEstudiante.Nombre;
    }
    if (miEstudiante.Calificacion > calificacionMayor){
        calificacionMayor = miEstudiante.Calificacion;
        nombreEstudiante = miEstudiante.Nombre;
    }
}
Console.WriteLine("El estudiante con Calificacion mayor es: " + nombreEstudiante + " con una calificacion de: " + calificacionMayor);
