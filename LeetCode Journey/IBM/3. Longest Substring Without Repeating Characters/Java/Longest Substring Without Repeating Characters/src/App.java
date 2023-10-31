public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("\n3. Longest Substring Without Repeating Characters");

        Solution solObj = new Solution();

        String s1 = "abcabcbb";
        System.out.println("\nExample 1 -->");
        int output1 = solObj.lengthOfLongestSubstring(s1);
        System.out.println("s: " + s1);
        System.out.println("output: " + output1);

        String s2 = "bbbbb";
        System.out.println("\nExample 2 -->");
        int output2 = solObj.lengthOfLongestSubstring(s2);
        System.out.println("s: " + s2);
        System.out.println("output: " + output2);
        
        String s3 = "pwwkew";
        System.out.println("\nExample 3 -->");
        int output3 = solObj.lengthOfLongestSubstring(s3);
        System.out.println("s: " + s3);
        System.out.println("output: " + output3);

    }
}
