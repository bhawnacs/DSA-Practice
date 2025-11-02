/*
-----------------------------------------------------
Title: 1D Array Practice - Count Even & Odd Numbers
Language: C#
Author: Bhawna
Description:
  This program demonstrates basic operations on 1D Arrays.
  - Count Even & Odd Numbers
-----------------------------------------------------
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
            //---------------------------------------//
            /* COUNT EVEN & ODD NUMBERS */

            int[] numbers = { 45, 46, 85, 88, 77, 66 };
            int evenCount = 0;
            int oddCount = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Even Numbers = " + evenCount);
            Console.WriteLine("Odd Numbers = " + oddCount);


            
        }
    }     
}
