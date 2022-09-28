using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_1_console
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("10;00");
            for (int min = 9; min >= 0; min = min - 1)
            {
                for (int seg = 59; seg >= 0; seg = seg - 1)
                {

                    Console.WriteLine(min + ":" + seg);
                   
                }
                

            }

        }
    }
}