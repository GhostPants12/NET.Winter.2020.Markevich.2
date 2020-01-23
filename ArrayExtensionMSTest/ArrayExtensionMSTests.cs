using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ArrayExtension.ArrayExtension;
using System.Linq;

namespace ArrayExtensionMSTest
{
    [TestClass]
    public class ArrayExtensionMSTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindBalanceIndex_WithNullArgument_ThrowArgumentNullException() => FindBalanceIndex(null);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindBalanceIndex_WithEmptyArray_ThrowArgumentNullException() => FindBalanceIndex(Array.Empty<int>());

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindMaximumElement_WithNullArgument_ThrowArgumentNullException() => FindMaximumElement(null);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMaximumElement_WithEmptyArray_ThrowArgumentNullException() => FindMaximumElement(Array.Empty<int>());

        [TestMethod]
        public void FindMaxElement_With100_000_000Array_ResultIs10_000_000()
        {
            int result=FindMaximumElement(Enumerable.Range(1, 100_000_000).ToArray());
            int expectedResult = 100_000_000;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
