using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ArrayExtension.ArrayExtension;

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
    }
}
