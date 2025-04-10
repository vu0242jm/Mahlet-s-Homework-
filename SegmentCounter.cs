// Written by Mahlet Gebremedhin
// April 9, 2025

using System;

public class Solution
{
    public int CountSegments(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        string[] segments = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return segments.Length;
    }
}
