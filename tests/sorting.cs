using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class SortingTests
    {
        [TestCase(new[] { 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1 }, true)]
        [TestCase(new[] { 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1 }, false)]
        [TestCase(new[] { 5, 6, 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [TestCase(new[] { 5, 6, 1, 2, 3, 4 }, new[] { 6, 5, 4, 3, 2, 1 }, false)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 6, 5, 4, 3, 2, 1 }, false)]
        [TestCase(new[] { 5, 99, 1, 2, 102, 3 }, new[] { 1, 2, 3, 5, 99, 102 }, true)]
        [TestCase(new[] { 5, 99, 1, 2, 102, 3 }, new[] { 102, 99, 5, 3, 2, 1 }, false)]
        public void BubbleSort(int[] input, int[] expected, bool ascending)
        {
            var list = input.ToList();
            Algorithms.Sorting.BubbleSort(list, ascending);
            CollectionAssert.AreEqual(list, expected.ToList());
        }

        [TestCase(new[] { 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1 }, true)]
        [TestCase(new[] { 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1 }, false)]
        [TestCase(new[] { 5, 6, 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [TestCase(new[] { 5, 6, 1, 2, 3, 4 }, new[] { 6, 5, 4, 3, 2, 1 }, false)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 6, 5, 4, 3, 2, 1 }, false)]
        [TestCase(new[] { 5, 99, 1, 2, 102, 3 }, new[] { 1, 2, 3, 5, 99, 102 }, true)]
        [TestCase(new[] { 5, 99, 1, 2, 102, 3 }, new[] { 102, 99, 5, 3, 2, 1 }, false)]
        public void InsertionSort(int[] input, int[] expected, bool ascending)
        {
            var list = input.ToList();
            Algorithms.Sorting.InsertionSort(list, ascending);
            CollectionAssert.AreEqual(list, expected.ToList());
        }

        [TestCase(new[] { 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1 }, true)]
        [TestCase(new[] { 1, 1, 1, 1, 1, 1 }, new[] { 1, 1, 1, 1, 1, 1 }, false)]
        [TestCase(new[] { 5, 6, 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [TestCase(new[] { 5, 6, 1, 2, 3, 4 }, new[] { 6, 5, 4, 3, 2, 1 }, false)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6 }, true)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 6, 5, 4, 3, 2, 1 }, false)]
        [TestCase(new[] { 5, 99, 1, 2, 102, 3 }, new[] { 1, 2, 3, 5, 99, 102 }, true)]
        [TestCase(new[] { 5, 99, 1, 2, 102, 3 }, new[] { 102, 99, 5, 3, 2, 1 }, false)]
        public void SelectionSort(int[] input, int[] expected, bool ascending)
        {
            var list = input.ToList();
            Algorithms.Sorting.SelectionSort(list, ascending);
            CollectionAssert.AreEqual(list, expected.ToList());
        }

        static object[] CarTestCases =
                                        {
                                            new object[] { new List<Car>() {new Car("Suzuki", 1990), new Car("Suzuki", 1989)},
                                                           new List<Car>() {new Car("Suzuki", 1989), new Car("Suzuki", 1990)},
                                                           true }
                                        };

        [TestCaseSource(nameof(CarTestCases))]
        public void BubbleSortGeneric(List<Car> input, List<Car> expected, bool ascending)
        {
            Algorithms.Sorting<Car>.BubbleSort(input, ascending);
            CollectionAssert.AreEqual(input, expected.ToList());
        }

        [TestCaseSource(nameof(CarTestCases))]
        public void InsertionSortGeneric(List<Car> input, List<Car> expected, bool ascending)
        {
            Algorithms.Sorting<Car>.InsertionSort(input, ascending);
            CollectionAssert.AreEqual(input, expected.ToList());
        }

        [TestCaseSource(nameof(CarTestCases))]
        public void SelectionSortGeneric(List<Car> input, List<Car> expected, bool ascending)
        {
            Algorithms.Sorting<Car>.SelectionSort(input, ascending);
            CollectionAssert.AreEqual(input, expected.ToList());
        }
    }
}
