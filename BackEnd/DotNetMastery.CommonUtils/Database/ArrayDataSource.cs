namespace DotNetMastery.CommonUtils.Database
{
    namespace DotNetMastery.CommonUtils.DataSources
    {
        public static class ArrayDataSource
        {
            // 1. Simple Sequential Array
            public static int[] GetSimpleArray()
            {
                return new int[] { 1, 2, 3, 4, 5 };
            }

            // 2. Unsorted Array (Perfect for testing LargestSmallest or Sorting)
            public static int[] GetUnsortedArray()
            {
                return new int[] { 34, 3, 89, 12, 5, 77 };
            }

            // 3. Array with Duplicates (Perfect for testing Duplicate logic)
            public static int[] GetArrayWithDuplicates()
            {
                return new int[] { 4, 5, 6, 4, 7, 8, 5, 9 };
            }

            // 4. Array with Negative Numbers
            public static int[] GetNegativeArray()
            {
                return new int[] { -10, -5, 0, 5, 10 };
            }
        }
    }
}
