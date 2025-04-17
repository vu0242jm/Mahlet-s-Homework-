public class Solution
{
    public int CalPoints(string[] ops)
    {
        int[] record = new int[ops.Length];
        int top = -1;

        foreach (string op in ops)
        {
            if (op == "C")
            {
                top--; // remove last score
            }
            else if (op == "D")
            {
                record[++top] = 2 * record[top];
            }
            else if (op == "+")
            {
                int sum = record[top] + record[top - 1];
                record[++top] = sum;
            }
            else
            {
                record[++top] = int.Parse(op);
            }
        }

        int total = 0;
        for (int i = 0; i <= top; i++)
        {
            total += record[i];
        }

        return total;
    }
}
