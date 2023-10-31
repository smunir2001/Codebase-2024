public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("\n7. Reverse Integer");

        Solution solObj = new Solution();
        
        int x1 = 123;
        int output1 = solObj.reverse(x1);
        System.out.println("\nExample 1 -->");
        System.out.println("x: " + x1);
        System.out.println("output: " + output1);

        int x2 = -123;
        int output2 = solObj.reverse(x2);
        System.out.println("\nExample 2 -->");
        System.out.println("x: " + x2);
        System.out.println("output: " + output2);

        int x3 = 120;
        int output3 = solObj.reverse(x3);
        System.out.println("\nExample 3 -->");
        System.out.println("x: " + x3);
        System.out.println("output: " + output3);
    }
}
