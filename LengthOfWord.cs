// Written By Mahlet Gebremedhin
// April 25/2025

public class Solution {
    public int LengthOfLastWord(string s) {
        int length = 0;
        bool inWord = false;

        
        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] != ' ') {
                
                length++;
                inWord = true;
            } else if (inWord) {
                
                break;
            }
        }

        return length;
    }
}
