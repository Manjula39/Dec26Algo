using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Algo
{
    internal class SelectionSort
    {
        static void SelectSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int ind_min = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[ind_min])
                    {
                        ind_min = j;
                        int temp = arr[ind_min];
                        arr[ind_min] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

        }

        static void PrintSelectSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("testing ");
            int[] nums = { 4, 2, 1, 8, 3 };
            SelectSort(nums);
            PrintSelectSort(nums);
        }
    }



        }