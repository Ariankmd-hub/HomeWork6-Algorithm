
namespace HomeWork6.Task8
{
    internal class TriangleChecker
    {
        public static bool CanFormTriangle(int[] arr)
        {
            if (arr == null || arr.Length < 3)
                return false;


            Array.Sort(arr);


            for (int i = 0; i < arr.Length - 2; i++)
            {
                if ((long)arr[i] + arr[i + 1] > arr[i + 2])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
