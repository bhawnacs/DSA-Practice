/*
-------------------------------------------------------------
Title: 1D Array Practice - Search Element
Language: C#
Author: Bhawna
Description:
  This program demonstrates basic operations on 1D Arrays.
   - To search for a specific number in an array.
-------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------//
            //           SEARCH ELEMENT              //
            //---------------------------------------//


            int[] numbers = { 45, 46, 85, 88, 77, 66 };

            Console.WriteLine("Enter a number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    Console.WriteLine("Number found at index " + i);

                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine("Number not found in the array");
            }

            
        }
    }     
}
