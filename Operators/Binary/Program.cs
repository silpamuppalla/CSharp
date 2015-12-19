using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prints the values 1 to 6
            int a,b,c;
            a = b = c=0;

            c = ++a + b;
            Console.WriteLine(c);
            c += c;
            Console.WriteLine(c);
            c += c - a;
            Console.WriteLine(c);
            c = c + a;
            Console.WriteLine(c);
            c = c / a + a++;
            Console.WriteLine(c);
            c = c % a + 2*a + ++b;
            Console.WriteLine(c);
            Console.ReadLine();   

        }
    }
}
