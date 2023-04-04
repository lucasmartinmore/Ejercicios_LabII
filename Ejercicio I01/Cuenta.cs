using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;
        public Cuenta(string titular)
        {
            this.cantidad = 0;
            this.titular = titular;
        }

        private void SetTitular(string titular)
        {
            this.titular = titular;
        }

        private void SetCantidad(double cantidad) 
        {
            this.cantidad += cantidad;
        }
        private string GetTitular()
        { 
            return this.titular; 
        }
        private double getCantidad() 
        {  
            return this.cantidad; 
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"=================");
            sb.AppendLine($"Titular:{this.GetTitular()}");
            sb.AppendLine($"Cantidad:{this.getCantidad()}");
            sb.AppendLine($"=================");
            return sb.ToString();
        }

        public void Ingresar(double dinero)
        { 
            if ( dinero > 0 ) 
            {
                this.SetCantidad(dinero);
                Console.WriteLine("Dinero ingresado correctamente");
            }
            else
            {
                Console.WriteLine("No se puede ingresar un valor negativo");
            }
        }

        public void Retirar(double dinero)
        {
            if ( dinero > 0 ) 
            {
                this.SetCantidad(-dinero);

                Console.WriteLine("Dinero retirado correctamente");
            }
            else
            {
                Console.WriteLine("No se puede retirar una cantida negativa de dinero");
            }
        }
    }
}
