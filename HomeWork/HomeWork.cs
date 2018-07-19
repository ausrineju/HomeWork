using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class HomeWork
    {
        public static void RandomNumbers()
        {
            Random num = new Random();
            Console.WriteLine("Random numbers from 1 to 10");
            for (int i=0; i<100; i++)
            {
                 Console.Write(num.Next(1, 10) + " " );
            }
        }

        static void Main(string[] args)
        {
            RandomNumbers();
            Console.ReadKey();
        }
    }
}
