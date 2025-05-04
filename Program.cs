using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibles_por_2_y_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int> {0, 1};
            Console.WriteLine("Indique el valor inicial");
            valores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique el valor Final");
            valores[1] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int numero = valores[0]; numero <= valores[1]; numero++)
            {
                if (numero % 2 == 0 && numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
