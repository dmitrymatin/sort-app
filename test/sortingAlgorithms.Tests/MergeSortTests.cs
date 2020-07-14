using System;
using System.Collections.Generic;
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
    }
}
