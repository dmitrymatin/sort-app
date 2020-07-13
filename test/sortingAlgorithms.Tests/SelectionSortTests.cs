using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace sortingAlgorithms.Tests
{
    public class SelectionSortTests
    {
        [Theory]
        [InlineData(new object[] { new int[] { 6, 5, 3, 1, 8, 7, 2, 4 } })]
        public void SelectionSortAscendingGivesCorrectOutput(int[] sampleArray)
        {
            // arrange
            int[] arrayForSelectionSort = new int[sampleArray.Length];
            sampleArray.CopyTo(arrayForSelectionSort, index: 0);

            // act
            Array.Sort(sampleArray);
            arrayForSelectionSort.SelectionSortAscendingInitial();

            // assert
            Assert.Equal(sampleArray, arrayForSelectionSort);
        }

    }
}
