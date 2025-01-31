using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_Cajero_Automatico
{
    public class CuentaBancaria
    {
        private string nombreTitular;
        public string NombreTitular
        {
            get { return nombreTitular; }
            set { nombreTitular = value; }
        }
        
        private double saldo;
        public double Saldo 
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine($"Depósito de ${monto} realizado.");
            }
            else
            {
                Console.WriteLine("Monto de depósito inválido.");
            }
        }

        public bool Retirar(double monto)
        {
            if (monto > 0 && monto <= saldo)
            {
                saldo -= monto;
                saldo = saldo - monto;
                Console.WriteLine($"Retiro de ${monto} realizado.");
                return true;
            }
            else
            {
                Console.WriteLine("Retiro no válido o saldo insuficiente.");
                return false;
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo actual de {nombreTitular}: ${saldo}");
        }
    }
}