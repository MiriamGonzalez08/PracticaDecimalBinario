using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**** DECIMAL A BINARIO ****");
            Console.WriteLine("Ingrese un número entero");
            int numDecimal = Convert.ToInt32(Console.ReadLine());
            string numBinario = "";

                           
            while (numDecimal > 0)
            {
                if (numDecimal % 2 == 0)
                {
                    numBinario = "0" + numBinario;
                }
                else
                {
                    numBinario = "1" + numBinario;
                }
                numDecimal = numDecimal / 2;
            }
            Console.WriteLine(numBinario);
            
            
            Console.ReadLine();
        }
    }
}
