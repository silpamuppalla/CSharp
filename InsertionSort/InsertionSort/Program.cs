using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[8] { 9, 6, 5, 0, 8, 2, 7, 1 };
            int key;
            int j, i;
            for (i = 1; i <= 7; i++)
            {
                key = A[i]; //pick the next element to insert

                /* Find the place to insert the element*/
                for (j = i; ((j > 0) && (key < A[j - 1])); j--)
                {
                    A[j] = A[j - 1];
                }
                /*Insert the key once the place is found*/
                A[j] = key;
            }

            foreach( int y in A)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();

        }
    }
}
