using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpzSortedContainer
{
	public class SortedContainer
	{
        //Сортировка вставками
        public static int[] InsertionSort(int[] arr)
        {
            int index, temp;
            for (int i = 0; i < arr.Length; ++i)
            {
                index = i;
                temp = arr[i];
                
                arr[index] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
    }
}
