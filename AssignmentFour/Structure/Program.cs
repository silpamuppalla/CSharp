using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***** Structure is a user defined type********/
/**** Structure is "Light Weight Class type" without inheritance****/

namespace Structure
{
    class Program
    {   struct Student  //struct is keyword
        {
        public int Id;
        public string Name;
        public char Section;
        }
        static void Main(string[] args)
        {
            Student myStudent;

            myStudent.Name = "Silpa"; //Intialization
            myStudent.Id = 101010;
            myStudent.Section='A';

            Console.WriteLine(" Name:{0}", myStudent.Name);
            Console.WriteLine(" Id:{0}", myStudent.Id);
            Console.WriteLine(" Section:{0}", myStudent.Section);

            Console.ReadLine();

        }
    }
}
