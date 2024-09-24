using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_22
{
    public class Articulo
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private double precio;
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
        private int cantidadVendida;
        public int CantidadVendida
        {
            get { return cantidadVendida; }
            set { cantidadVendida = value; }
        }

        public double CalcularSubtotal(){
            return precio*cantidadVendida;
        }
        public double CalcularIVA(){
            return CalcularSubtotal()*.16;
        }

        public double CalcularDescuento(){
            return CalcularSubtotal()*.02;
        }
        
    }
}