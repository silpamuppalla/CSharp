using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[8] {6, 5, 3, 1, 8, 7, 2, 4};
            int temp;
            for (int i = 7; i > 0; i--)
            {
                for (int j=0;j<i;j++)
                {
                    if(A[j]>A[j+1])
                    {
                        temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }       
            }

            foreach (int x in A)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
