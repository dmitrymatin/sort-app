using System;
using System.Collections.Generic;
using System.Text;

namespace sortingAlgorithms
{
    public static class SelectionSortExtension
    {
        public static void SelectionSortAscendingInitial<T>(this IList<T> list, Comparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;

            for (int i = 0; i < list.Count - 1; i++)
            {
                int minElemIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparer.Compare(list[j], list[minElemIndex]) < 0)
                    {
                        minElemIndex = j;
                    }
                }
                
                if (i != minElemIndex)
                {
                    list.Swap(i, minElemIndex);
                }
            }
        }
    }
}
