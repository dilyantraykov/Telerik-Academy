using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingHomework.Tests
{
    [TestClass]
    public class SearchAlgorithmsTests
    {
        [TestMethod]
        public void LinearSearchShouldWorkCorrectlyWithMiddleElement()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Assert.IsTrue(collection.LinearSearch(33));
        }

        [TestMethod]
        public void LinearSearchShouldWorkCorrectlyWithFirstElement()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Assert.IsTrue(collection.LinearSearch(22));
        }

        [TestMethod]
        public void LinearSearchShouldWorkCorrectlyWithLastElement()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Assert.IsTrue(collection.LinearSearch(101));
        }

        [TestMethod]
        public void LinearSearchShouldWorkCorrectlyWhenNoSuchElementIsPresent()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            Assert.IsFalse(collection.LinearSearch(5));
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWithMiddleElement()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            Assert.IsTrue(collection.BinarySearch(33));
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWithFirstElement()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            Assert.IsTrue(collection.BinarySearch(0));
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWithLastElement()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            Assert.IsTrue(collection.BinarySearch(101));
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWhenNoSuchElementIsPresent()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            Assert.IsFalse(collection.LinearSearch(55));
        }
    }
}
