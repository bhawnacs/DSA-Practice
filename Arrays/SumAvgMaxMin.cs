/*
-----------------------------------------------------
Title: 1D Array Practice - Sum, Average, Max & Min
Language: C#
Author: Bhawna
Description:
  This program demonstrates basic operations on 1D Arrays.
  - Calculates the sum and average of array elements
  - Finds the maximum and minimum values in the array
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
            // ---------------------------
            // 1. SUM AND AVERAGE
            // ---------------------------

            int[] numbers = { 89, 78, 65, 58, 48, 92 };
            int sum = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum = " + sum);

            double average = (double)sum / numbers.Length;
            Console.WriteLine("Average = " + average);


            // ---------------------------
            // 2. MAXIMUM AND MINIMUM
            // ---------------------------

            int[] numbers1 = { 45, 65, 11, 78, 99, 58, 87 };
            int max = numbers1[0];
            int min = numbers1[0];

            for ( int i1 = 1; i1 < numbers1.Length; i1++)
            {
                if (numbers1[i1] > max)
                {
                    max = numbers1[i1];
                }
                if (numbers1[i1] < min)
                {
                    min = numbers1[i1];
                }
            }
            Console.WriteLine("Maximum Number = " + max);
            Console.WriteLine("Minimum Number = " + min);

            Console.ReadLine();


            
        }
    }     
}
