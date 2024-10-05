using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ_5
{
    public class PagoMensual
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int autosVendidos;
        public int AutosVendidos
        {
            get { return autosVendidos; }
            set { autosVendidos = value; }
        }

        public double CalcularSBruto(){
            double SBruto = 0;
            return SBruto = autosVendidos > 15 ? 350+40+(autosVendidos*15):350+(autosVendidos*15);
        }

        public double CalcularImpuesto(){
            return CalcularSBruto()*.05;
        }        
        
    }
}