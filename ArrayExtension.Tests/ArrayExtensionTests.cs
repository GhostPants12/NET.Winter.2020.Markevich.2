using NUnit.Framework;
using System;
using static ArrayExtension.ArrayExtension;

namespace ArrayExtension.Tests
{
    public class ArrayExtensionTests
    {
        [TestCase(new int[10] { 10, 1, 2, 2, 1, 1, 1, 1, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[5] { 1, 2, 3, 4, 6 }, ExpectedResult = 3)]
        [TestCase(new int[2] { 0, 0 }, ExpectedResult = null)]
        [TestCase(new int[1] { 1 }, ExpectedResult = null)]
        [TestCase(new int[3] { 0,0,1 }, ExpectedResult = null)]
        public int? FindBalanceIndex_WithAllValidParameters(int[] arr) =>
            FindBalanceIndex(arr);
    }
}