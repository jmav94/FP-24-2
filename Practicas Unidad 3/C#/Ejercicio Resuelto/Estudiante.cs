using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_Resuelto
{
    public class Estudiante
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int calificacion;
        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        
    }
}