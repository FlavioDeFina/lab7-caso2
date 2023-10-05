using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_caso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;
            for (int i = 1; i <= 1000; i++) 
            {
                resultado = i * 3;
                Console.WriteLine("Divisor de Alonso De Fina "+i+": "+resultado);
            }
            Console.ReadKey();
        }
    }
}
