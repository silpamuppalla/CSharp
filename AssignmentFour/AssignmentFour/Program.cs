using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************UNDERSTANDING ARRAYS*****************
****Array is a set of data items accessed using data index********
****Array is a contagious space of same data type              */
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Understanding Arrays");
            SimpleArrays();
            ArrayOfInitialization();
            ImplicitlyTypedArrays();
            ArrayOfObjects();
            Console.ReadLine();
            
        }
        static void SimpleArrays()
        {
            //Create an array of integers
            int[] myUsYears= new int[3];
            myUsYears[0] = 2014;
            myUsYears[1] = 2015;
            myUsYears[2] = 2016;
            
            foreach( int i in myUsYears) //Print each value in the array using foreach iteration
            {
                Console.WriteLine(i);
            }
            //Create array of Strings
            string[] myQuote=new string[3];
            myQuote[0] = "Practicing";
            myQuote[1] = "C#";
            myQuote[2] = "Honestly";

            foreach(string x in myQuote)
            {

                Console.Write(x+" ");
                //Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ArrayOfInitialization()
        {
            string[] myString = new string[] { "one", "two", "three" }; //Array Intialization with the New

            bool[] myBool = { true, false, true }; //Array Intialization without new

            int[] myInt = new int[4] { 55, 66, 77, 88 }; //Array intialization with new and size

            Console.WriteLine("Sting is initialized with {0} elements", myString.Length);
            Console.WriteLine("Bool is initialized with {0} elements", myBool.Length);
            Console.WriteLine("Int is initialized with {0} elements", myInt.Length);//Formatting console output
        }

        static void ImplicitlyTypedArrays()
        {
            // "var" keyword allows to define a variable and whoose type is defined by the compiler
            var x= new  [] { 1, 2, 4 };    //syntax is diff just like normal variable
            Console.WriteLine( "x is a {0}",x.ToString());//ToString inorder to write the textual representation of current type
        }
       static void ArrayOfObjects()
       {
         //mixed type with arrays possible...YES with array of objects***************
           object[] arrayOfObj = new object[3];
           arrayOfObj[0]=1000; //int
           arrayOfObj[1]=true;//bool
           arrayOfObj[2]="SILPA";//string

           foreach( object x in arrayOfObj )
           {
               Console.WriteLine("Type : {0} Value: {1}", x.GetType(), x);//GetType vs ToString??
           }

        }
    }
}
