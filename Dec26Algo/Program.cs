using System;//root or base namespace
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Dec26Algo
{
    internal class Program
    {
        static void BSort(int[] arr)
        {
            int temp = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void PrintAfterBSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13, 3 };
            int temp = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("after buble sort");
            foreach (int x in arr) Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}