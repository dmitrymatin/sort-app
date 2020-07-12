using System;
using System.Collections.Generic;
using System.Text;

namespace sortingAlgorithms
{
    public static class InsertionSortExtension
    {
        public static void InsertionSortAscending<T>(this IList<T> list, Comparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;

            for (int i = 1; i < list.Count; i++)
            {
                if (comparer.Compare(list[i - 1], list[i]) > 0)      // if previous element is greater than current.
                {
                    var current = list[i];
                    var currentIndex = i;
                    for (int j = 0; j < currentIndex; j++)           // loop through all elements on the left (those are sorted) until current.
                    {
                        if (comparer.Compare(current, list[j]) < 0)  // if current is less than an element in that left section.
                        {
                            var moveStartIndex = j;
                            for (int k = currentIndex; k > moveStartIndex/*list.Count - 1*/; k--) // right move section between element that turned out to be 
                            {                                                                     // greater than current and current element by one position.
                                list[k] = list[k - 1];
                            }

                            list[moveStartIndex] = current;
                            break;
                        }
                    }
                }
            }
        }
    }
}