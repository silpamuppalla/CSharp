using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/***** Rectangular Array*****
 ***** Jagged Array**********/
namespace MultiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myMatrix = new int[6 ,6];

            for (int i=0;i<6;i++)
            {
                for (int j=0;j<6;j++)
                {
                    myMatrix[i,j] = i * j;
                }
            }
            Console.WriteLine("Rectangualr Array");
            Console.WriteLine();
            for ( int i=0;i<6;i++)
            {

                for(int j=0;j<6;j++)
                {
                    Console.Write(myMatrix[i, j] + "\t"); //To print the matrix 
                }
                Console.WriteLine(); // to go for new line after one row
            }

           /******* JAGGED ARRAY****/

            jaggedArray();

            Console.ReadLine();
        }

        static void jaggedArray()
        {
            string[][] skillArray = new string[3][]; //Jagged array of arrays 3 arrays here
            skillArray[0] = new string[3]; //Assigning the length for each array
            skillArray[1] = new string[2];
            skillArray[2] = new string[3];

            skillArray[0][0] = "C++";   //Programming Languages
            skillArray[0][1] = "JAVA";
            skillArray[0][2] = "C#";

            skillArray[1][0] = "SQL Server"; //Data Bases
            skillArray[1][1] = "SQL Developer";
            //skillArray[0][2] = "C#";

            skillArray[2][0] = "HTML"; //Web Development
            skillArray[2][1] = "CSS";
            skillArray[2][2] = "JAVA SCRIPT";

            Console.WriteLine("Jagged Array");
            Console.WriteLine();
            for (int i=0;i<skillArray.Length;i++)
            {
                Console.WriteLine("SKILL{0}", i);
                
                for (int j=0;j<skillArray[i].Length;j++)
                {
                    Console.WriteLine(skillArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
