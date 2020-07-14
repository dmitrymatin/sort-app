using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace sortingAlgorithms
{
    public static class MergeSortExtension
    {
        public static void MergeSort<T>(this IList<T> list, Comparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;

            int l = 0;
            int r = list.Count - 1;

            Sort(list, l, r, comparer);
        }

        private static void Sort<T>(IList<T> list, int left, int right, Comparer<T> comparer)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort(list, left, middle, comparer);
                Sort(list, middle + 1, right, comparer);

                Merge(list, left, middle, right, comparer);
            }
        }

        private static void Merge<T>(IList<T> list, int left, int middle, int right, Comparer<T> comparer)
        {
            int sizeLeftArr = middle - left + 1;
            int sizeRightArr = right - middle;

            T[] leftArr = new T[sizeLeftArr];
            T[] rightArr = new T[sizeRightArr];

            int index;
            for (index = 0; index < leftArr.Length; index++)
            {
                leftArr[index] = list[left + index];
            }

            for (index = 0; index < rightArr.Length; index++)
            {
                rightArr[index] = list[middle + 1 + index];
            }

            int i, j;
            i = j = 0;
            int k = left;

            while (i < sizeLeftArr && j < sizeRightArr)
            {
                if (comparer.Compare(leftArr[i], rightArr[j]) <= 0)
                {
                    list[k] = leftArr[i];
                    i++;
                }
                else
                {
                    list[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < sizeLeftArr)
            {
                list[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < sizeRightArr)
            {
                list[k] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}
