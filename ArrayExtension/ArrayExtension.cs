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
            for (int i = 1; i < arr.Length - 1; i++)
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

        /// <summary>Finds the maximum element of an array.</summary>
        /// <param name="arr">The array.</param>
        /// <returns>Maximum element of the array.</returns>
        /// <exception cref="ArgumentNullException">Argument is null.</exception>
        /// <exception cref="ArgumentException">Array is empty.</exception>
        public static int FindMaximumElement(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Argument is null.");
            }

            if (arr.Length == 0)
            {
                throw new ArgumentException("Array is empty.");
            }

            return MaximumInRange(arr, 0, arr.Length - 1);
        }

        private static int MaximumInRange(int[] arr, int leftNumber, int rightNumber)
        {
            if (leftNumber == rightNumber)
            {
                return arr[rightNumber];
            }
            else
            {
                int leftBuff = MaximumInRange(arr, leftNumber, (leftNumber + rightNumber) / 2);
                int rightBuff = MaximumInRange(arr, ((leftNumber + rightNumber) / 2) + 1, rightNumber);

                return Math.Max(leftBuff, rightBuff);
            }
        }
    }
}
