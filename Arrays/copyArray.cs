/*
--------------------------------------------------------------
Title: 1D Array Practice - Copy Array
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
            //----------------------------------------//
            //           COPY ARRAY                  //
            //---------------------------------------//


            int[] numbers = { 45, 46, 85, 88, 77, 66 };
            int[] copy = new int[numbers.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                copy[i] = numbers[i];
            }
            Console.WriteLine("Copied array element:");

            for(int i = 0; i < copy.Length; i++)
            {
                Console.Write(copy[i] + " ");
            }
            
            
        }
    }     
}
