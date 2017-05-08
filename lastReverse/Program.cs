using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersEdedler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Birinci Ededi daxil edin");
   
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>101)
            {
                Console.WriteLine("Ilk ededi 100 daxil etmenizi xahis edirem \n");
                Console.WriteLine(" Birinci Ededi yeniden daxil edin");
                a = Convert.ToInt32(Console.ReadLine());
              
            }

            Console.WriteLine(" Ikinci ededi daxil edin \n");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" \n");
            int k = b / a;

            int v = a / 100 - 1;
            int i, j;

            for (j = 0; j < k-1; j++)
            {
                v++;
                for (i = 0; i < 100; i += 10)
                {
                    int r = v * 100 + i + v;
                    Console.WriteLine(r);
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine(" Minnetdaram \n");


            Console.Read();



        }
    }
}
