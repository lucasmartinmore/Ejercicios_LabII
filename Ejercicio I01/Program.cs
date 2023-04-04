namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta CuentaUno = new Cuenta("Lucas");
            CuentaUno.Ingresar(5600.50);
            Console.WriteLine(CuentaUno.Mostrar());
            //Retiro 
            CuentaUno.Retirar(7000);
            Console.WriteLine(CuentaUno.Mostrar());
        }
    }
}