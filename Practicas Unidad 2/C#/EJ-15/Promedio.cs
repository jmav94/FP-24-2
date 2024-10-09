using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ_15
{
    public class Promedio
    {
        private int a;
        public int A    
        {
            get { return a; }
            set { a = value; }
        }
        private int b;
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        private int c;
        public int C
        {
            get { return c; }
            set { c = value; }
        }
        private int d;
        public int D
        {
            get { return d; }
            set { d = value; }
        }
        private int e;
        public int E
        {
            get { return e; }
            set { e = value; }
        }
        
        public double Calcular(){
            int mayor = A;
            int menor = A;

            if (B>mayor)
            {
                mayor = B;
            }else if(B < menor){
                menor = B;
            }
            if (C> mayor)
            {
                mayor = C;
            }else if(C<menor){
                menor = C;
            }
            if (D>mayor)
            {
                mayor=D;
            }else if(D<menor){
                menor=D;
            }
            if (E>mayor)
            {
                mayor=E;
            }else if(E<menor){
                menor=E;
            }

            return (A + B + C + D + E - mayor - menor) / 3.0;
        }
    }
}