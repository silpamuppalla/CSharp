using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{

    interface IName
    {
        void name();

    }
    interface ICountry
    {
        void country();
    }
    class Program :IName,ICountry
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.name();
            p.country();
            Console.ReadLine();
        }

        public void name()
        {
            Console.WriteLine("My Name is SILPA");
        }
        public void country()
        {
            Console.WriteLine("Im Living in USA");
        }
    }
}
