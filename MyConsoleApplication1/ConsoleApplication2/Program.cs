using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
        class Name
        {
           static void Main()
            {
                string x, y;

                Console.WriteLine("Enter Your First Name");

                x = Console.ReadLine();
                Console.WriteLine("Enter Your Last Name");
                y = Console.ReadLine();
                Console.Write("Your First Name is: {0 }", x);

                Console.WriteLine("  Your Last Name is :{0}", y);

                Console.ReadLine();
            }
        }
}
