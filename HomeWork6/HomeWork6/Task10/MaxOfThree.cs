namespace HomeWork6.Task10
{
    internal class MaxOfThree
    {
        public static long Find(int[] arr)
        {
            if (arr == null || arr.Length < 3)
                throw new ArgumentException("Array must contain at least 3 numbers.");

            Array.Sort(arr);
            int n = arr.Length;

            long result1 = (long)arr[n - 1] * arr[n - 2] * arr[n - 3];
            long result2 = (long)arr[0] * arr[1] * arr[n - 1];

            return Math.Max(result1, result2);
        }

    }
}
