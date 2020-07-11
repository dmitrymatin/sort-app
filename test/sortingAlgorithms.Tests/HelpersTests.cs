using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace sortingAlgorithms.Tests
{
    public class HelpersTests
    {
        [Theory]
        [InlineData(new object[] { new int[] { 3, 2 } })]
        public void SwapWorksCorrectly(int[] data)
        {
            // arrange
            int indexA = 0;
            int indexB = 1;

            int leftAfter = data[indexB];
            int rightAfter = data[indexA];

            // act
            data.Swap(indexA, indexB);

            // assert
            Assert.Equal(data[indexA], leftAfter);
            Assert.Equal(data[indexB], rightAfter);
        }
    }
}
