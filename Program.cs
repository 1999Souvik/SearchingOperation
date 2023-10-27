using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SearchingOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10] { 56, 67, 24, 76, 54, 82, 83, 88, 90, 29 };

            Console.WriteLine("Enter marks to search and press Enter:");
            string input = Console.ReadLine();
            int search = Int32.Parse(input);

            int binarySearchIndex = BinarySearch.Search(marks, search);
            //int linearSearchIndex = LinearSearch.Search(marks, search);

            if (binarySearchIndex != -1)
            {
                Console.WriteLine(search + " was found using binary search at location " + binarySearchIndex);
            }
            else
            {
                Console.WriteLine(search + " was not found .");
            }

            //if (linearSearchIndex != -1)
            //{
            //    Console.WriteLine(search + " was found using linear search at location " + linearSearchIndex);
            //}
            //else
            //{
            //    Console.WriteLine(search + " was not found .");
            //}

            Console.ReadLine(); 
        }
    }
}






