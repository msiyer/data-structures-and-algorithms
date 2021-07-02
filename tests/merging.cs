using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    [TestFixture]
    class MergingTests
    {
        [TestCase(new[] { 1, 3, 5, 7, 9}, new[] { 2, 4, 6, 8, 10}, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
        [TestCase(new[] { 1, 3, 5, 7, 9, 11, 13}, new[] { 2, 4, 6, 8, 10}, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13})]
        [TestCase(new[] { 1, 1}, new[] { 1, 1}, new[] { 1, 1, 1, 1})]
        // unsorted lists get merged in funny ways
        [TestCase(new[] { 5, 4, 3}, new[] { 8, 7, 9}, new[] { 5, 4, 3, 8, 7, 9})]
        [TestCase(new[] { 5, 4, 3}, new[] { 3, 7, 9}, new[] { 3, 5, 4, 3, 7, 9})]
        public void Merge(int[] firstInput, int[] secondInput, int[] thirdInput)
        {
            var firstList = firstInput.ToList();
            var secondList = secondInput.ToList();
            var expectedOutput = thirdInput.ToList();
            CollectionAssert.AreEqual(Algorithms.Merging.TwoWayMergeIterative(firstList, secondList), expectedOutput);
        }
    }
}
