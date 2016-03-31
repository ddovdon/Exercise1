using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        const int iTwo = 2, iSeven = 7;
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if (IsMultiples(iTwo, i) && IsMultiples(iSeven, i))
                {
                    Console.WriteLine("CrossShield");
                }
                else if (IsMultiples(iTwo, i))
                {
                    Console.WriteLine("Cross");
                }
                else if (IsMultiples(iSeven, i))
                {
                    Console.WriteLine("Shield");
                }
                else
                {
                    Console.WriteLine("Number: {0}", i);
                }
            }
            Console.ReadKey();
        }        

        static bool IsMultiples(int number, int index)
        {
            return (index % number) == 0;
        }
    }
}
