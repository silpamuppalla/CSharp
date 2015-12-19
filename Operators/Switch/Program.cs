using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =1;

            while(x != 0 )
            {

            switch(x)
                {

                  case 1:
                     Console.Write("NEW JERSEY ");
                     x=2;
                     break;
                 case 2:
                     Console.Write("IS A STATE ");
                     x=3;
                     break;

                 case 3:
                     Console.WriteLine("IN USA");
                     x=0;
                     break;
                default:
                    break;

                }
            }
            Console.ReadLine();
        }
    }
}
