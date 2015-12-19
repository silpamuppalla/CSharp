using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace MyConsoleApplication1
{
     class Name
    {
        static void Main(string[] args)
        {
            String x, y;
            Console.WriteLine("Enter Your First Name");
            x = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            y = Console.ReadLine();
            Console.WriteLine("Your First Name is " + x + "  Your Last Name is " + y);
            Console.ReadLine();
        }
    }
}
