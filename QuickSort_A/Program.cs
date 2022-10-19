using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_A
{

    class Program
    {
        //array of intergers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0;//number of comparasion
        private int mov_count = 0;//number of data movements

        //Number of elements in array
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
