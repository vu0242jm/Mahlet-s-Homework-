// written by mahlet 
// april 16/2025

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int total = 0;
        for (int i = 0; i < nums.Length; i++)
            total += nums[i];

        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int rightSum = total - leftSum - nums[i];
            if (leftSum == rightSum)
                return i;

            leftSum += nums[i];
        }

        return -1;
    }
}
