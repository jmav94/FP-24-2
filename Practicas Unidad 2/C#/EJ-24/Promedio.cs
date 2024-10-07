using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ_24
{
    public class Promedio
    {
        private int c1;
        public int C1
        {
            get { return c1; }
            set { c1 = value; }
        }
        private int c2;
        public int C2
        {
            get { return c2; }
            set { c2 = value; }
        }
        private int c3;
        public int C3
        {
            get { return c3; }
            set { c3 = value; }
        }
        
        public double Calcular(){
            double p = (c1+c2+c3)/3.0;
            return Math.Round(p,2);
        }

        public string Mensaje(){
            double p = Calcular();
            string M = "";

            if (p == 100.00)
            {
                M = "Excelente";
            }else if (p >= 90.00)
            {
                M = "Muy bien";
            }else if(p >= 80)
            {
                M = "Bien";
            }else if (p >= 70)
            {
                M = "Hay que mejorar";
            }else if (p < 70)
            {
                M = "Reprobado";
            }
            
            return $"Tu calificacion es de: {p} {M}";
        }
        
    }
}