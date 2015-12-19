using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Branches:byte   //Underlying storage for enum
        {
            ComputerScience =10, // by default it starts with 0 and increment by 1
            ElectricalEng=11,
            InformationSystems=12  //For the last it does not have any comma
        }
        static void Main(string[] args)
        {
            Branches College;
            College = Branches.ComputerScience; //Illegal to assign the value not defined .cant assign Civil Engineering

            BranchDetails(College);
            Console.ReadLine();

        }

        static void BranchDetails( Branches b)
        {

            switch(b)
            {
                case Branches.ComputerScience :

                    Console.WriteLine("This Is Computer Science");
                    break;
                case Branches.ElectricalEng:
                    break;
                case Branches.InformationSystems:
                    break;
                default:
                    break;
            }

        }
    }
}
