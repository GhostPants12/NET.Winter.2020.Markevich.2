namespace ArrayExtension
{
    using System;

    /// <summary>
    /// An application entry point.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>Finds the index of the "balance" element.</summary>
        /// <param name="arr">The array.</param>
        /// <returns>Returns index of element if it exists or null.</returns>
        /// <exception cref="System.ArgumentNullException">Argument is null.</exception>
        /// <exception cref="System.ArgumentException">Array is empty.</exception>
        public static int? FindBalanceIndex(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Argument is null.");
            }

            if (arr.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            if (arr.Length < 3)
            {
                return null;
            }

            int sumBeforeElement;
            int sumAfterElement;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                sumBeforeElement = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    sumBeforeElement += arr[j];
                }

                sumAfterElement = 0;
                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    sumAfterElement += arr[j];
                }

                if (sumBeforeElement == sumAfterElement)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
