using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using Xunit;

namespace sortingAlgorithms.Tests
{
    public class BubbleSortTests
    {
        [Theory]
        [InlineData(new object[] { new int[] { 3, 2, 4, 1 } })]
        public void BubbleSortAscendingGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForBubbleSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForBubbleSort, index: 0);

            // act
            Array.Sort(sampleArray);
            arrayForBubbleSort.BubbleSortAscending(order: SortingOrder.Ascending);

            // assert
            Assert.Equal(sampleArray, arrayForBubbleSort);
        }

        [Theory]
        [InlineData(new object[] { new int[] { 3, 2, 4, 1 } })]
        public void BubbleSortDescendingGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForReverseBubbleSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForReverseBubbleSort, index: 0);

            // act
            Array.Sort(sampleArray, new Comparison<int>(
                (i1, i2) => i2.CompareTo(i1))
            );
            arrayForReverseBubbleSort.BubbleSortDescending(order: SortingOrder.Descending);

            // assert
            Assert.Equal(sampleArray, arrayForReverseBubbleSort);
        }

        [Theory]
        [InlineData(1000)]
        public void BubbleSortIsFast(int arrSize)
        {
            // arrange
            int[] arr = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrBubble = new int[arrSize];
            arr.CopyTo(arrBubble, 0);

            long arrTime, arrBubbleTime;
            var stopwatch = new Stopwatch();


            // act
            stopwatch.Start();
            Array.Sort(arr);
            stopwatch.Stop();
            arrTime = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            arrBubble.BubbleSortAscending();
            stopwatch.Stop();
            arrBubbleTime = stopwatch.ElapsedTicks;

            var diff = ((arrBubbleTime - arrTime) / (double)arrTime) * 100;


            // assert
            Assert.InRange(diff, -100, 12000);
        }

        [Theory]
        [InlineData(10000)]
        public void BubbleSortIsEquallyFastForAllOrders(int arrSize)
        {
            // arrange
            int[] arrAsc = new int[arrSize];
            var ran = new Random();
            for (var i = 0; i < arrAsc.Length; i++)
            {
                arrAsc[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrDesc = new int[arrSize];
            arrAsc.CopyTo(arrDesc, 0);

            long ascTime, descTime;
            var stopwatch = new Stopwatch();


            // act
            stopwatch.Start();
            arrAsc.BubbleSortAscending();
            stopwatch.Stop();
            ascTime = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            arrDesc.BubbleSortDescending();
            stopwatch.Stop();
            descTime = stopwatch.ElapsedTicks;

            var diff = ((descTime - ascTime) / (double)ascTime) * 100;

            // assert
            Assert.InRange(diff, -5, 5);
        }
    }
}
