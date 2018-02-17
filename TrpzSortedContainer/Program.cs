using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpzSortedContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 6, 1, 10, 8, 0 };
            TestSort(arr, SortetContainer.BubbleSort);
            TestSort(arr, SortetContainer.InsertionSort);
            TestSort(arr, SortetContainer.MergeSort);
            TestSort(arr, SortetContainer.ShakerSort);
            Console.ReadKey();
        }

        private static void TestSort(int[] arr, SortMethod method)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            method(arr);
            watch.Stop();
            TimeSpan span = watch.Elapsed;
            Console.WriteLine("Затраченое время на сортировку {0} : {1}", method.Method.Name, span.Ticks);
        }
    }
}
