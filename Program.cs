using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    internal class Program
    {   //array to be reached
        int[] arr = new int[20];
        //number of elements in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements i the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\narray should have minimum 1 and maximum 20 elements.\n");
            }
            //accept array elements
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("enter array elements");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

        }
        static void Main(string[] args)
        {
            char ch;
            do
            {
                //acc the number to be searched
                Console.Write("\nenter element want you to search ; ");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = 0;

                //obtain
            }
        }
    }
}
