namespace HomeWork6
{
    internal static class ConsoleHelper
    {
        // برای حالتی که مثلا کاربر یک عدد بخواد وارد کنه . برای validation
        public static int ReadInt(string message) 
        {
            Console.Write(message);
            int result;
           
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input! Please enter a valid number: ");
            }
            return result;
        }
        public static int[] ReadIntArray() 
        {
            int size;
            do
            {
                size = ReadInt("How many numbers you want to put in? ");
                if (size <= 0)
                {
                    Console.WriteLine("Size must be a positive number! Try again.");
                }
            } while (size <= 0);

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = ReadInt($"Input number {i + 1}: ");
            }

            return arr;
        }
        public static string ReadString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Invalid input! Please enter a non-empty string: ");
                input = Console.ReadLine();
            }

            return input;
        }

    }
}


