using NUnit.Framework;
using System;
using System.Linq;
using static ArrayExtension.ArrayExtension;

namespace ArrayExtension.Tests
{
    public class ArrayExtensionTests
    {
        [TestCase(new int[10] { 10, 1, 2, 2, 1, 1, 1, 1, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[5] { 1, 2, 3, 4, 6 }, ExpectedResult = 3)]
        [TestCase(new int[2] { 0, 0 }, ExpectedResult = null)]
        [TestCase(new int[3] { 0, 0, 0 }, ExpectedResult = 1)]
        [TestCase(new int[1] { 1 }, ExpectedResult = null)]
        [TestCase(new int[3] { 0,0,1 }, ExpectedResult = null)]
        public int? FindBalanceIndex_WithAllValidParameters(int[] arr) =>
            FindBalanceIndex(arr);

        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, ExpectedResult = 5)]
        [TestCase(new int[3] { 99999998, 99999999, 100000000 }, ExpectedResult = 100000000)]
        [TestCase(new int[10] { -1,2,-3,4,-5,6,-7,8,-9,10}, ExpectedResult =10)]
        public static int FindMaximumElement_WithAllValidParameters(int[] arr)
        {
            return FindMaximumElement(arr);
        }
    }
}