using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("The MSG is " + i);
            }

            for (int j = 10; j >= 1; --j)
            {
                Console.WriteLine("hello " + j);
            }
            for(; ; )
            {
                Console.WriteLine("contiue"); // this is contionue and infinity foe loop
            }

            Console.ReadLine();

        }
    }
}
