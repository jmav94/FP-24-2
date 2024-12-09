using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    public class Venta
    {
        double[] miArreglo = new double[12];
        public double this[int celda]
        {
            get { return miArreglo[celda]; }
            set { miArreglo[celda] = value; }
        }

        public double CalcularPromedio(){
            double promedio = 0;
            foreach (double mes in miArreglo)
            {
                promedio += mes;
            }
            return promedio/12;
        }

        public double CalcularVentaMayor(){
            double ventaMayor = miArreglo[0];
            foreach (double mes in miArreglo)
            {
                if (mes > ventaMayor)
                {
                    ventaMayor = mes;
                }
            }
            return ventaMayor;
        }  

        public int CalcularMesVentaMenor(){
            int mesMenor = 0;
            double mesVentaMenor = miArreglo[0];

            for (int i = 0; i < miArreglo.Length; i++)
            {
                if (miArreglo[i] < mesVentaMenor)
                {
                    mesVentaMenor = miArreglo[i];
                    mesMenor = i;
                }
            }
            return mesMenor + 1;
        }
    }
}