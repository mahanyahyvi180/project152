using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp114
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count;

            for(Count=1;Count<=10;++Count)
            {
                if (Count == 5)
                {
                    break;
                }
                    Console.Write($"{Count}");
                }

            Console.WriteLine($"\n Broke out of loop at count={Count}");
            Console.ReadLine();
        }
    }
}
