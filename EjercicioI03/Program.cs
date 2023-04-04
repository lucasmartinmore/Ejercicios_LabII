namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string respuesta;
            int binario;
            int decim;

            bool rta = PedirNumeroDecimal(out numero);
            if(rta)
            {
                respuesta = Conversor.ConvertirDecimalABinario(numero);
                Console.WriteLine($"El numero {numero} convertido a binario seria: {respuesta}");

            }

            bool rta2 = PedirNumeroBinario(out binario);
            if(rta2) 
            {
                decim = Conversor.ConvertirBinarioADecimal(binario);
                Console.WriteLine($"El numero {binario} binario convertido a decimal seria: {decim}");
            }
        }

        public static bool PedirNumeroDecimal(out int numero)
        {
            Console.WriteLine("Ingrese un numero decimal a convertir en binario: ");
            numero = int.Parse(Console.ReadLine());

            return true;
        }

        public static bool PedirNumeroBinario(out int numero)
        {
            Console.WriteLine("Ingrese un numero binario a convertir en decicmal: ");
            numero = int.Parse(Console.ReadLine());

            return true;
        }
    }
}