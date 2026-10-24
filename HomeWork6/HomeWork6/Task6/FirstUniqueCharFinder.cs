
namespace HomeWork6.Task6
{
    internal static class FirstUniqueCharFinder
    {
        public static string FindFirstUnique(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "-1";

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            foreach (char c in input)
            {
                if (charCounts[c] == 1)
                {
                    return c.ToString();
                }
            }

            return "-1";
        }
    }
}
