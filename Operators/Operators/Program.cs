using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Unary
    {
        static void Main(string[] args)
        {
           //This program prints 1001
            int X = 1;
            Console.Write(X--);
            Console.Write(X++);
            Console.Write(--X);
            Console.WriteLine(++X);
            Console.ReadLine();
        }
    }
}
