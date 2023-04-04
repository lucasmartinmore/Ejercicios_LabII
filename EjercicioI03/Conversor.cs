using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI03
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            string binario = "";

            if(numeroEntero > 0) 
            {
                while(numeroEntero > 0) 
                {
                    if(numeroEntero%2 == 0) //par 
                    {
                        binario = "0"+binario;
                    }
                    else //impar 
                    {
                        binario = "1"+binario;
                    }

                    numeroEntero = numeroEntero/2;
                }
            }
            else if(numeroEntero == 0) 
            {
                binario = "0";
            }
            else
            {
                binario = "No se puede convertir a binario un numero negativo";
            }

            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            double exponente = 0;
            double decim = 0;
            int numero;

            while((numeroEntero / 10) != 0) 
            {
                numero = numeroEntero % 10;
                decim = decim + numero * Math.Pow(2.00, exponente);
                exponente++;
                numeroEntero = numeroEntero / 10;   
            }
            decim = decim + numeroEntero * Math.Pow(2.0, exponente);

            return (int)decim;
        }
    }
}
