namespace HomeWork6.Task9
{
    internal static class ParenthesesValidator
    {
        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
        
            if (s.Length % 2 != 0)
                return false;

            Stack<char> stack = new Stack<char>();

            foreach (char ch in s)
            {
           
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
      
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if (ch == ')' && top != '(') return false;
                    if (ch == ']' && top != '[') return false;
                    if (ch == '}' && top != '{') return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
