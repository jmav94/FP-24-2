class TemperaturaGradosFarenheit
{
// Atributo privado
private double _dblGradosFarenheit;
// Propiedad pública de solo escritura
public double GradosFarenheit
{
set { _dblGradosFarenheit = value; }
}
public double ConvertirAGradosCentigrados()
{
return (5 * (_dblGradosFarenheit - 32) / 9);
}
}