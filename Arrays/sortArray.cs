/*
---------------------------------------------------------------
Title: 1D Array Practice - Sort Array
Language: C#
Author: Bhawna
Description:
  This program demonstrates basic operations on 1D Arrays.
---------------------------------------------------------------
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
            //------------------------------------//
            //          Sort Array                //
            //------------------------------------//

            int[] numbers = { 44, 55, 68, 91, 22, 38 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Arraty: ");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            
        }
    }     
}
