using System;
using System.Collections;
using System.Collections.Generic;
using static sortingAlgorithms.Helpers;

namespace sortingAlgorithms
{
    public static class BubbleSortExtension
    {
        public static void BubbleSortAscending<T>(this IList<T> list, Comparer<T> comparer = null, SortingOrder order = SortingOrder.Ascending)
        {
            comparer ??= Comparer<T>.Default;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    var current = j;
                    var next = j + 1;
                    if (comparer.Compare(list[current], list[next]) > 0)
                    {
                        list.Swap(current, next);
                    }
                }
            }
        }

        public static void BubbleSortDescending<T>(this IList<T> list, Comparer<T> comparer = null, SortingOrder order = SortingOrder.Descending)
        {
            comparer ??= Comparer<T>.Default;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    var current = j;
                    var next = j + 1;
                    if(comparer.Compare(list[current], list[next]) < 0)
                    {
                        list.Swap(current, next);
                    }
                }
            }
        }
    }
}
