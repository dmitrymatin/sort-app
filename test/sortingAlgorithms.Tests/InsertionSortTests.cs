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
        public void InsertionSortAscendingInitialGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForInsertionSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForInsertionSort, index: 0);

            // act
            Array.Sort(sampleArray);
            arrayForInsertionSort.InsertionSortAscendingInitial();

            // assert
            Assert.Equal(sampleArray, arrayForInsertionSort);
        }

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
        [InlineData(1000)]
        public void InsertionSortAscendingGivesCorrectOutputOnRandomArrays(int arrSize)
        {
            // arrange
            int[] sampleArray = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < sampleArray.Length; i++)
            {
                sampleArray[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrayForInsertionSort = new int[arrSize];
            sampleArray.CopyTo(arrayForInsertionSort, index: 0);

            // act
            Array.Sort(sampleArray);
            arrayForInsertionSort.InsertionSortAscending();

            // assert
            Assert.Equal(sampleArray, arrayForInsertionSort);
        }

        [Theory]
        [InlineData(new object[] { new int[] { 6, 5, 3, 1, 8, 7, 2, 4 } })]
        public void InsertionSortDescendingGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForReverseInsertionSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForReverseInsertionSort, index: 0);

            // act
            Array.Sort(sampleArray, new Comparison<int>(
                (i1, i2) => i2.CompareTo(i1))
            );
            arrayForReverseInsertionSort.InsertionSortDescending();

            // assert
            Assert.Equal(sampleArray, arrayForReverseInsertionSort);
        }

        [Theory]
        [InlineData(20000)]
        public void InsertionSortAscendingInitialANDInsertionSortAscendingAreEquallyFast(int arrSize)
        {
            // arrange
            int[] arrInsertionSortInitial = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < arrInsertionSortInitial.Length; i++)
            {
                arrInsertionSortInitial[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrInsertionSort = new int[arrSize];
            arrInsertionSortInitial.CopyTo(arrInsertionSort, 0);

            long insertionSortInitialTime, insertionSortTime;
            var stopwatch1 = new Stopwatch();
            var stopwatch2 = new Stopwatch();


            // act
            stopwatch1.Start();
            arrInsertionSortInitial.InsertionSortAscendingInitial();
            stopwatch1.Stop();
            insertionSortInitialTime = stopwatch1.ElapsedTicks;

            stopwatch2.Start();
            arrInsertionSort.InsertionSortAscending();
            stopwatch2.Stop();
            insertionSortTime = stopwatch2.ElapsedTicks;

            var diff = ((insertionSortTime - insertionSortInitialTime) / (double)insertionSortInitialTime) * 100; // percentage


            // assert
            Assert.InRange(diff, -5, 5);
        }

        [Theory]
        [InlineData(20000)]
        public void InsertionSortAscendingANDInsertionSortAscendingInitialAreEquallyFast(int arrSize)
        {
            // arrange
            int[] arrInsertionSort = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < arrInsertionSort.Length; i++)
            {
                arrInsertionSort[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrInsertionSortInitial = new int[arrSize];
            arrInsertionSort.CopyTo(arrInsertionSortInitial, 0);

            long insertionSortTime, insertionSortInitialTime;
            var stopwatch1 = new Stopwatch();
            var stopwatch2 = new Stopwatch();


            // act
            stopwatch1.Start();
            arrInsertionSort.InsertionSortAscending();
            stopwatch1.Stop();
            insertionSortTime = stopwatch1.ElapsedTicks;

            stopwatch2.Start();
            arrInsertionSortInitial.InsertionSortAscendingInitial();
            stopwatch2.Stop();
            insertionSortInitialTime = stopwatch2.ElapsedTicks;

            var diff = ((insertionSortInitialTime - insertionSortTime) / (double)insertionSortTime) * 100; // percentage


            // assert
            Assert.InRange(diff, -5, 5);
        }

        [Theory]
        [InlineData(20000)]
        public void InsertionSortInitialAndBubbleSortAreEquallyFast(int arrSize)
        {
            // arrange
            int[] arrBubbleSort = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < arrBubbleSort.Length; i++)
            {
                arrBubbleSort[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrInsertionSort = new int[arrSize];
            arrBubbleSort.CopyTo(arrInsertionSort, 0);

            long arrBubbleSortTime, arrInsertionSortTime;
            var stopwatch1 = new Stopwatch();
            var stopwatch2 = new Stopwatch();


            // act
            stopwatch1.Start();
            arrBubbleSort.BubbleSortAscending();
            stopwatch1.Stop();
            arrBubbleSortTime = stopwatch1.ElapsedTicks;

            stopwatch2.Start();
            arrInsertionSort.InsertionSortAscendingInitial();
            stopwatch2.Stop();
            arrInsertionSortTime = stopwatch2.ElapsedTicks;

            var diff = ((arrInsertionSortTime - arrBubbleSortTime) / (double)arrBubbleSortTime) * 100; // percentage


            // assert
            Assert.InRange(diff, -30, 30);
        }
    }
}
