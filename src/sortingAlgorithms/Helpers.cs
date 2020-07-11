using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace sortingAlgorithms
{
    public static class Helpers
    {
        public static void Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
        }
    }

    public enum SortingOrder
    {
        Ascending = 0,
        Descending = 1
    }
}
