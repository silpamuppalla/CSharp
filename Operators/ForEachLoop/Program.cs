using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] s = { "SUMAN", "CHERRY", "MANASA", "SEJAL", "SILPA" };

            foreach(string v in s)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
    }
}
