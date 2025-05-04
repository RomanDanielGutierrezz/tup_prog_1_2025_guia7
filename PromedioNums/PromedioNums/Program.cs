using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            double numero, acumulador = 0;
            for (int i = 1; i <= 10; i++)
            {
                bool verificador = false;

                while (!verificador)
                {
                    Console.WriteLine($"Ingrese nuemro {i}");
                    string entrada = Console.ReadLine();
                    
                    if (double.TryParse(entrada, out numero))
                    {
                        acumulador += numero;
                        contador++;
                        verificador = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ingrese un numero/valor valido");
                        Console.WriteLine();
                    }
                }

            }
            var prom =acumulador / contador;
            Console.WriteLine($"Su promedio de numeros es {prom}");
        }   
    }
}
