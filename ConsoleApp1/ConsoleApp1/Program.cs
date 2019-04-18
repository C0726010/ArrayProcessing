using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] fre1 = new int[100];
            int n, i, j, ctr;


            Console.Write("Give the input of number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n); /*part1*/
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fre1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        fre1[j] = 0;
                    }
                }

                if (fre1[i] != 0)
                {
                    fre1[i] = ctr;
                }
            }
            Console.Write("\nThe fre1 of all elements of the array : \n");/*part 2*/
        }
    }
}
