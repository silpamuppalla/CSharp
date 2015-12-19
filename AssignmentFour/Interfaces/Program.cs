using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*** Interface is nothing more than a named set of abstract members****/
namespace Interfaces

{    interface IMyInterface
     {
       void add( int a,int b);
     }
    class Program :IMyInterface
    {
        static void Main(string[] args)
        {
            Program myAdd = new Program();

            myAdd.add(11,22);

            Console.ReadLine();

        }
        public void add( int x, int y)
        {
            Console.WriteLine("Addition is {0}", x + y);
        }
    }
}
