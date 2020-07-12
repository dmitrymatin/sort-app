using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace sortingAlgorithms.Tests
{
    public class InsertionSortTests
    {
        [Theory]
        [InlineData(new object[] { new int[] { 6, 5, 3, 1, 8, 7, 2, 4 } })]
        public void InsertionSortAscendingGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForInsertionSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForInsertionSort, index: 0);

            // act
            Array.Sort(sampleArray);
            arrayForInsertionSort.InsertionSortAscending();

            // assert
            Assert.Equal(sampleArray, arrayForInsertionSort);
        }

        [Theory]
        [InlineData(10000)]
        public void InsertionSortAndBubbleSortAreEquallyFast(int arrBubbleSize)
        {
            // arrange
            int[] arrBubbleSort = new int[arrBubbleSize];
            var ran = new Random();
            for (var i = 0; i < arrBubbleSort.Length; i++)
            {
                arrBubbleSort[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrInsertionSort = new int[arrBubbleSize];
            arrBubbleSort.CopyTo(arrInsertionSort, 0);

            long arrBubbleSortTime, arrInsertionSortTime;
            var stopwatch = new Stopwatch();


            // act
            stopwatch.Start();
            arrBubbleSort.BubbleSortAscending();
            stopwatch.Stop();
            arrBubbleSortTime = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            arrInsertionSort.InsertionSortAscending();
            stopwatch.Stop();
            arrInsertionSortTime = stopwatch.ElapsedTicks;

            var diff = ((arrInsertionSortTime - arrBubbleSortTime) / (double)arrBubbleSortTime) * 100; // percentage


            // assert
            Assert.InRange(diff, -30, 30);
        }
    }
}
