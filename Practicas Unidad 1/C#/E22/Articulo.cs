using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E22
{
    public class Articulo
    {
        //Atributos
        private string nombre;
        private double precio;               
        private int cantidadVendida;
        
        
        // Metodos y propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int CantidadVendida
        {
            get { return cantidadVendida; }
            set { cantidadVendida = value; }
        }

        public double CalcularIVA(){
            return (CalcularSubtotal())*.16;
        }

        public double CalcularDescuento(){
            return (CalcularSubtotal())*.02;
        }

        public double CalcularSubtotal(){
            return precio * cantidadVendida;
        }

        public double CalcularTotal(){
            return CalcularSubtotal() + CalcularIVA() + CalcularDescuento();
        }
    }
}