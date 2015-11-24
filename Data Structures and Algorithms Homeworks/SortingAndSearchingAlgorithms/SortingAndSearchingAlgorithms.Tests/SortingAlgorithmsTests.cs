namespace SortingHomework.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SortingAlgorithmsTests
    {
        [TestMethod]
        public void SelectionSortShouldSortCorrectly()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            collection.Sort(new SelectionSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void SelectionSortShouldSortCorrectlyWithSortedElements()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            collection.Sort(new SelectionSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void QuickSortShouldSortCorrectly()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            collection.Sort(new Quicksorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }


        [TestMethod]
        public void QuickSortShouldSortCorrectlyWithSortedElements()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            collection.Sort(new Quicksorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void MergeSortShouldSortCorrectly()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            collection.Sort(new MergeSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }

        [TestMethod]
        public void MergeSortShouldSortCorrectlyWithSortedElements()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            collection.Sort(new MergeSorter<int>());

            for (int i = 0; i < collection.Items.Count - 1; i++)
            {
                Assert.IsTrue(collection.Items[i] <= collection.Items[i + 1]);
            }
        }
    }
}