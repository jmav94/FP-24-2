using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ_9
{
    public class AnioNacimiento
    {
        private int anio;
        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        
        
        public bool DeterminarBisiesto()
        {
            bool bisiesto;
            if (anio % 4 == 0){
                bisiesto = true;
            }else{
                bisiesto = false;
            }
            
            return bisiesto;
        }
    }
}