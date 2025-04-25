// Written By Mahlet Gebremedhin 
// April 25/2025

public class Solution {
    public bool IsHappy(int n) {
        int slow = n;
        int fast = GetNext(n);

        while (fast != 1 && slow != fast) {
            slow = GetNext(slow);
            fast = GetNext(GetNext(fast));
        }

        return fast == 1;
    }

    
    private int GetNext(int num) {
        int total = 0;
        while (num > 0) {
            int digit = num % 10;
            total += digit * digit;
            num = num / 10;
        }
        return total;
    }
}
