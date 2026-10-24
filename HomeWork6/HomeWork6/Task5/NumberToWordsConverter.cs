namespace HomeWork6.Task5
{
    internal static class NumberToWordsConverter
    {
        private static readonly string[] Units =
        {
            "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private static readonly string[] Tens =
        {
            "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        public static string Convert(int number)
        {
            if (number < 1 || number > 9999)
            {
                return "Number out of range (1 - 9999)";
            }

            string result = "";

        
            if (number >= 1000)
            {
                result += Units[number / 1000] + " Thousand ";
                number %= 1000; 
            }

           
            if (number >= 100)
            {
                result += Units[number / 100] + " Hundred ";
                number %= 100; 
            }

           
            if (number > 0)
            {
                if (number < 20)
                {
                    result += Units[number];
                }
                else
                {
                    result += Tens[number / 10];
                    if (number % 10 > 0)
                    {
                        result += " " + Units[number % 10];
                    }
                }
            }

            return result.Trim(); 
        }
    }
}

