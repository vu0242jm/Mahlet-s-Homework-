// written by mahlet 
// april 16/2025
public class RecentCounter
{
    private int[] times;
    private int start;
    private int end;

    public RecentCounter()
    {
        times = new int[10000];
        start = 0;
        end = 0;
    }

    public int Ping(int t)
    {
        times[end++] = t; // add t at the end

        // Remove times that are too old
        while (times[start] < t - 3000)
        {
            start++;
        }

        return end - start;
    }
}
