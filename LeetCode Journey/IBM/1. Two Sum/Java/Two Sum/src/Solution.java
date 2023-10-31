import java.util.HashMap;

public class Solution {
    public Solution() {}
    
    /*
     * Single-pass hashtable
     * Time complexity: O(n)
     * Space complexity: O(n)
     * Runtime: 2ms
     * Memory: 43.41MB
     */
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> numsMap = new HashMap<>();
        for (int i = 0; i < nums.length; i++) {
            int complement = target - nums[i];
            if (numsMap.containsKey(complement) && numsMap.get(complement) != i) {
                return new int[] {i, numsMap.get(complement)};
            }
            numsMap.put(nums[i], i);
        }
        return null;
    }
}