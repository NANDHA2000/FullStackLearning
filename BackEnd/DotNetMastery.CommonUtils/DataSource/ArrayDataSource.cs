namespace DotNetMastery.CommonUtils.DataSources
{
    public static class ArrayDataSource
    {
        // Sequential sorted array
        public static int[] GetSimpleArray() => new int[] { 1, 2, 3, 4, 5 };

        // Unsorted numbers for sorting and min/max search
        public static int[] GetUnsortedArray() => new int[] { 34, 3, 89, 12, 5, 77 };

        // Arrays with duplicates for frequency and distinct checks
        public static int[] GetArrayWithDuplicates() => new int[] { 4, 5, 6, 4, 7, 8, 5, 9 };

        // Signed numbers for zero-crossing and math routines
        public static int[] GetNegativeArray() => new int[] { -10, -5, 0, 5, 10 };

        // Target array for Two-Sum and Sliding Window problems
        public static int[] GetTargetSumArray() => new int[] { 2, 7, 11, 15, 3, 6, 8 };
    }
}