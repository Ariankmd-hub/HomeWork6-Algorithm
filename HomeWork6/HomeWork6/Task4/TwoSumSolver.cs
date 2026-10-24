namespace HomeWork6.Task4
{
    internal class TwoSumSolver
    {
        public static bool HasTwoSum(int[] arr, int target)
        {
            if (arr == null || arr.Length < 2)
                return false;

            HashSet<int> seenNumbers = new HashSet<int>();
            // create set with nothing in it .
            foreach (int currentNum in arr)
            {
                int neededNumber = target - currentNum;

                if (seenNumbers.Contains(neededNumber))
                {
                    return true;
                }


                seenNumbers.Add(currentNum);
            }

            return false;



        }
    }
}
