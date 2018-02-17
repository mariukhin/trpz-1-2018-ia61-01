using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpzSortedContainer
{
    public class SortedContainer
    {
        //Сортировка перемешиванием
        public static int[] ShakerSort(int[] arr)
        {
        }

        private static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
    }
}
