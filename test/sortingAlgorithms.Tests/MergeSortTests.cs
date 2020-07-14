using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace sortingAlgorithms.Tests
{
    public class MergeSortTests
    {
        [Theory]
        [InlineData(new object[] { new int[] { 6, 5, 3, 1, 8, 7, 2, 4 } })]
        public void MergeSortGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForMergeSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForMergeSort, index: 0);

            // act
            Array.Sort(sampleArray);
            arrayForMergeSort.MergeSort();

            // assert
            Assert.Equal(sampleArray, arrayForMergeSort);
        }

        [Theory]
        [InlineData(100000)]
        public void MergeSortIsFast(int arrSize)
        {
            // arrange
            int[] arr = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrMergeSort = new int[arrSize];
            arr.CopyTo(arrMergeSort, 0);

            long arrTime, arrMergeSortTime;
            var stopwatch1 = new Stopwatch();
            var stopwatch2 = new Stopwatch();


            // act
            stopwatch1.Start();
            Array.Sort(arr);
            stopwatch1.Stop();
            arrTime = stopwatch1.ElapsedTicks;

            stopwatch2.Start();
            arrMergeSort.MergeSort();
            stopwatch2.Stop();
            arrMergeSortTime = stopwatch2.ElapsedTicks;

            var diff = ((arrMergeSortTime - arrTime) / (double)arrTime) * 100;


            // assert
            Assert.InRange(
                actual: diff, 
                low: double.MinValue, 
                high: 5000
            );
        }

        [Theory]
        [InlineData(20000)]
        public void MergeSort_Outperforms_InsertionSort(int arrSize)
        {
            // arrange
            int[] mergeSort = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < mergeSort.Length; i++)
            {
                mergeSort[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrInsertionSort = new int[arrSize];
            mergeSort.CopyTo(arrInsertionSort, 0);

            long mergeSortTime, insertionSortTime;
            var swMerge = new Stopwatch();
            var swInsert = new Stopwatch();


            // act
            swMerge.Start();
            mergeSort.MergeSort();
            swMerge.Stop();
            mergeSortTime = swMerge.ElapsedTicks;

            swInsert.Start();
            arrInsertionSort.InsertionSortAscending();
            swInsert.Stop();
            insertionSortTime = swInsert.ElapsedTicks;

            var diff = ((insertionSortTime - mergeSortTime) / (double)mergeSortTime) * 100; // percentage


            // assert
            Assert.True(diff > 0);
        }
    }
}
