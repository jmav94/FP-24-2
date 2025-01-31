using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJ_26
{
    public class PolizaSeguro
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        
        private double valorVehiculo;
        public double ValorVehiculo
        {
            get { return valorVehiculo; }
            set { valorVehiculo = value; }
        }
        private int modelo;
        public int Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        
        private int numAccidentes;
        public int NumAccidentes
        {
            get { return numAccidentes; }
            set { numAccidentes = value; }
        }

        public double CargoModelo(){
            double cargo = 0;
            if (modelo <= 90 )
            {
                cargo = valorVehiculo * 0.001;
            }
            else if (modelo >= 91 && modelo <= 97)
            {
                cargo = valorVehiculo * 0.003;
            }
            else if (modelo >= 98 )
            {
                cargo = valorVehiculo * 0.005;
            }
            return cargo;
        }
    
        public int CargoEdad(){
            int cargo = 0;
            if (edad >= 18 && edad <= 23)
            {
                cargo = 350;
            }
            else if (edad >= 24 && edad <= 55)
            {
                cargo = 200;
            }
            else if (edad >= 56 && edad <= 65)
            {
                cargo = 300;
            }
            return cargo;
        }

        public int CargoAccidentesPrevios(){
            int cargo = 0;
            if (numAccidentes <= 3)
            {
                cargo = numAccidentes * 15;
            }else if (numAccidentes >= 4)
            {
                cargo = (numAccidentes -3) * 20 + 45;
            }
            return cargo;
        }
        
    }
}