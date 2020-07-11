using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace sortingAlgorithms.Tests
{
    public class BubbleSortTests
    {
        [Theory]
        [InlineData(new object[] { new int[] { 3, 2, 4, 1 } })]
        public void BubbleSortGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForBubbleSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForBubbleSort, index: 0);

            // act
            Array.Sort(sampleArray);
            arrayForBubbleSort.BubbleSort(order: SortingOrder.Ascending);

            // assert
            Assert.Equal(sampleArray, arrayForBubbleSort);
        }


        [Fact]
        public void BubbleSortIsFast()
        {
            // arrange
            const int size = 100;
            int[] arr = new int[size];
            var ran = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = ran.Next(int.MinValue, int.MaxValue);
            }

            int[] arrBubble = new int[size];
            arr.CopyTo(arrBubble, 0);

            long arrTime, arrBubbleTime;
            var stopwatch = new Stopwatch();

            // act
            stopwatch.Start();
            Array.Sort(arr);
            stopwatch.Stop();
            arrTime = stopwatch.ElapsedTicks;

            stopwatch.Restart();
            arrBubble.BubbleSort();
            stopwatch.Stop();
            arrBubbleTime = stopwatch.ElapsedTicks;

            var diff = ((arrBubbleTime - arrTime) / (double)arrTime) * 100;

            // assert
            Assert.InRange(diff, -100, 12000);
        }
    }
}
