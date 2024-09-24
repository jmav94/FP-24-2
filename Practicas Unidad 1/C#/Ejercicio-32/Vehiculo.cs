using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_32
{
    public class Vehiculo
    {
        //Atributos
        private double costo;
        //Metodos y Propiedades
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public double CalcularCostoFinal(){
            return costo+(costo*.12)+(costo*.06);
        }
        
    }
}
