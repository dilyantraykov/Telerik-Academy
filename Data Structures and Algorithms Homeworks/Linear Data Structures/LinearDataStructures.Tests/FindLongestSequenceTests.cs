namespace LinearDataStructures.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FindLongestSequenceTests
    {
        [TestMethod]
        public void FindLongestSequenceShouldWorkCorrectlyWithJustOneNormalSequence()
        {
            var numbers = new List<int> { 1, 1, 2, 2, 2, 3, 4 };
            var sequence = FindLongestSequence.Startup.GetLongestEqualSubsequence(numbers);
            var expectedSequence = new List<int> { 2, 2, 2 };
            CollectionAssert.AreEqual(expectedSequence, sequence);
        }

        [TestMethod]
        public void FindLongestSequenceShouldReturnFirstSequenceWhenThereAreMoreThanOneEqualSequences()
        {
            var numbers = new List<int> { 1, 1, 2, 2, 3, 4 };
            var sequence = FindLongestSequence.Startup.GetLongestEqualSubsequence(numbers);
            var expectedSequence = new List<int> { 1, 1 };
            CollectionAssert.AreEqual(expectedSequence, sequence);
        }

        [TestMethod]
        public void FindLongestSequenceShouldReturnEmptyListWhenGivenEmptyList()
        {
            var numbers = new List<int>();
            var sequence = FindLongestSequence.Startup.GetLongestEqualSubsequence(numbers);
            var expectedSequence = new List<int>();
            CollectionAssert.AreEqual(expectedSequence, sequence);
        }
    }
}
