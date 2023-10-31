import java.util.Arrays;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("1. Two Sum");
        
        Solution solObj = new Solution();
        int[] nums1 = {2, 7, 11, 15};
        int target1 = 9;
        int[] output1 = solObj.twoSum(nums1, target1);
        System.out.println("\nExample 1 -->");
        System.out.println("nums[]: " + Arrays.toString(nums1));
        System.out.println("target: " + target1);
        System.out.println("output: " + Arrays.toString(output1));

        int[] nums2 = {3, 2, 4};
        int target2 = 6;
        int[] output2 = solObj.twoSum(nums2, target2);
        System.out.println("\nExample 2 -->");
        System.out.println("nums[]: " + Arrays.toString(nums2));
        System.out.println("target: " + target2);
        System.out.println("output: " + Arrays.toString(output2));

        int[] nums3 = {3, 3};
        int target3 = 6;
        int[] output3 = solObj.twoSum(nums3, target3);
        System.out.println("\nExample 3 -->");
        System.out.println("nums[]: " + Arrays.toString(nums3));
        System.out.println("target: " + target3);
        System.out.println("output: " + Arrays.toString(output3));
    }
}
