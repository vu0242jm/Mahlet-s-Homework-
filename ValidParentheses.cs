public class Solution
{
    public bool IsValid(string s)
    {
        char[] brackets = new char[s.Length];
        int top = -1;

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                brackets[++top] = c; // push
            }
            else
            {
                if (top < 0) return false;

                char open = brackets[top--]; // pop

                if ((c == ')' && open != '(') ||
                    (c == '}' && open != '{') ||
                    (c == ']' && open != '['))
                {
                    return false;
                }
            }
        }

        return top == -1;
    }
}
