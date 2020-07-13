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

        public static int MinIndex<T>(this IList<T> list, int startIndex, int endIndex, Comparer<T> comparer)
        {
            comparer ??= Comparer<T>.Default;

            int minIndex = startIndex;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (comparer.Compare(list[i], list[minIndex]) < 0)
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }

    public enum SortingOrder
    {
        Ascending = 0,
        Descending = 1
    }
}
