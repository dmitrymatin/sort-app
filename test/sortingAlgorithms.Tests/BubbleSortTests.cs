using System;
using System.Collections.Generic;
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
    }
}
