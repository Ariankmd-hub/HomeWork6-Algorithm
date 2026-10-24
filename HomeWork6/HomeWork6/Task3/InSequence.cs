namespace HomeWork6.Task3
{
    //Increasing sequence
    internal class InSequence
    {
        public static int Find(int[] arr) 
        {
            if (arr == null || arr.Length == 0)
                return 0;
            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength) { maxLength = currentLength; }
                }
                else 
                {
                    currentLength = 1;
                }
                
                

            }

            return maxLength;
        }
    }
}
