import java.util.HashSet;

public class Solution {
    public Solution() {}
    
    /*
     * Sliding window
     * Time complexity: O(n)
     * Space complexity: O(n)
     * Runtime: 6ms
     * Memory: 43.47MB
     */
    public int lengthOfLongestSubstring(String s) {
        int left = 0;
        int right = 0;
        int maxLength = 0;
        HashSet<Character> charSet = new HashSet<>();
        while (right < s.length()) {
            if (!(charSet.contains(s.charAt(right)))) {
                charSet.add(s.charAt(right));
                right++;
                maxLength = Math.max(charSet.size(), maxLength);
            } else {
                charSet.remove(s.charAt(left));
                left++;
            }
         }
        return maxLength;
    }
}