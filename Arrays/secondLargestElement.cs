/*
---------------------------------------------------------------
Title: 1D Array Practice - Second Largest Element
Language: C#
Author: Bhawna
Description:
  This program demonstrates operations on 1D Arrays.
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
            //        Second Largest Element      //
            //------------------------------------//

            int[] numbers = { 10, 45, 22, 67, 99, 54 };

            int first = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > first)
                {
                    second = first;
                    first = numbers[i];
                }
                else if (numbers[i] > second && numbers[i] != first)
                {
                    second = numbers[i];
                }
            }

            Console.WriteLine("Second largest element = " + second);



        }
    }     
}
