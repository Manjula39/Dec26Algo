﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Algo
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 60, 15, 15, 100, 1 };
            int n = arr.Length, i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            for (i = 1; i < n; i++)
            {
                val = arr[i]; flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j]; j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("  Sorted  Array is: ");
            for (i = 0; i < n; i++)
            {
                {
                    Console.WriteLine(arr[i] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
          