using System;

namespace Ejercicio_15_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            string numero = Console.ReadLine();

            int baseNumero = 10;
            int baseConversion = 16;

            string resultado = Convert.ToString(Convert.ToInt32(numero, baseNumero), baseConversion);
            Console.WriteLine("\nEl número " + numero + " en hexadecimal es: " + resultado);
        }
    }
}
