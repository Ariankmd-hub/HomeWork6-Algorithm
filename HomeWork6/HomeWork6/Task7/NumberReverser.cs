namespace HomeWork6.Task7
{
    internal class NumberReverser
    {

        public static int Reverse(int number)
        {
            long reversed = 0;

            while (number != 0)
            {
                int remainder = number % 10;     
                reversed = (reversed * 10) + remainder; 
                number /= 10;                     
            }

     
            if (reversed < int.MinValue || reversed > int.MaxValue)
            {
                return 0;
            }

            return (int)reversed;
        }
    }
}