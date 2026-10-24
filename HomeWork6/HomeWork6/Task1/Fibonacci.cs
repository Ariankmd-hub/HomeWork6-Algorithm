namespace HomeWork6.Task1
{
    internal class Fibonacci
    {
        public static long Calculate (int n) 
        {
            if (n <= 0) { return 0; }
            if (n == 1) { return 1; }

            long a = 0;
            long b = 1;
            long temp;

            for (int i = 2; i <= n; i++) 
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
            

        }

        
       
    }
}
