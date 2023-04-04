namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int numero;
            char seguir = 'A';

            do 
            {
                bool rta = PedirNumero(out  numero);
                if (rta) 
                {
                    acumulador += numero;
                }

                bool rta2 = DeseaContinuar(out seguir);

            }while(Validador.ValidarRespuesta(seguir));

            Console.WriteLine($"La cantidad total acumulada es de {acumulador}");
        }

        public static bool PedirNumero(out int numero) 
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine()); 

            return true;
        }
        
        public static bool DeseaContinuar(out char respuesta) 
        {
            Console.WriteLine("Desea seguir ingresando: ");
            respuesta = char.Parse(Console.ReadLine()); 

            return true;
        }
    }
}