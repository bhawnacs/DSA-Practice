/*
-----------------------------------------------------
Title: 1D Array Practice - Reverse an Array
Language: C#
Author: Bhawna
Description:
  This program demonstrates basic operations on 1D Arrays.
  
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
            //          REVERSE AN ARRAY             //
            //---------------------------------------//


            int[] numbers = { 45, 46, 85, 88, 77, 66 };
            int[] reversed = new int[numbers.Length];

            int j = 0;

            for ( int i = numbers.Length - 1; i >= 0; i--)
            {
                reversed[j] = numbers[i];
                j++;
            }
            Console.WriteLine("Reversed Array:");

            for ( int i = 0; i < reversed.Length; i++)
            {
                Console.WriteLine(reversed[i] + " ");
            }

            
        }
    }     
}
