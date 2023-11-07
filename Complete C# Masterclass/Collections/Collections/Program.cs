/*
    Sami Munir
    Rutgers University
    smunir2001@gmail.com
    October 25, 2023
*/

using System.Collections;
using System.Text;
using System.Threading.Tasks;
using Collections;

public class Program {
    public static void Main(string[] args) {
        /*
            Arrays
        */
        int[] nums = new int[4];
        for (int i = 0; i < nums.Length; i++) {
            nums[i] = (i + 1);
        }
        Console.WriteLine("nums.toString(): " + nums.ToString());
        for (int i = 0; i < nums.Length; i++) {
            Console.WriteLine("\tElement #{0}: {1}", i, nums[i]);
        }

        int[] nums2 = new int[] {2, 4, 6, 8, 10};
        Console.WriteLine("\nnums2.toString(): " + nums2.ToString());
        int index = 0;
        foreach (int num in nums) {
            Console.WriteLine("\tElement #{0}: {1}", index, num);
            index++;
        }

        string[] friends = {"Meenah", "Hass", "Arham", "Sabrina"};
        Console.WriteLine("\nfriends.toString(): " + friends.ToString());
        index = 0;
        foreach (string friend in friends) {
            Console.WriteLine("\tFriend #{0}: {1}", index, friend);
            index++;
        }

        /* Console.Write("\nPlease enter the input: ");
        string input = Console.ReadLine();
        while (input != "abc") {
            Console.WriteLine("Input {" + input + "} is rejected... try again!");
            Console.Write("Please enter the input: ");
            input = Console.ReadLine();
        } */

        // Declare a 2-d array
        string[,] nameMatrix;

        // Declare a 3-d array
        int[,,] numMatrix;

        int[,] twoDimArray = new int[,] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("\ntwoDimArray.toString(): " + twoDimArray.ToString());
        Console.WriteLine("\ttwoDimArray[1, 1]: " + twoDimArray[1, 1]);
        Console.WriteLine("\ttwoDimArray.Rank: " + twoDimArray.Rank);
        Console.Write("\t");
        foreach (int element in twoDimArray) {
            Console.Write(element + " ");
        }
        Console.Write("\n\n");
        for (int i = 0; i < twoDimArray.GetLength(0); i++) {
            for (int k = 0; k < twoDimArray.GetLength(1); k++) {
                Console.Write(twoDimArray[i, k] + " ");
            }
            Console.WriteLine();
        }

        /*
            Params keyword
        */
        string[] input = {"This", "is", "a", "long", "string", "I", "have", "no", "idea", "when", "..."};
        // paramsMethod(input);
        // paramsMethod(); // can run without any parameters (w/o any compilation issue).
        // paramsMethodv2(1, '$', "hello", 3.14);

        int min = minV2(7, 23, 14, 89, 122, 54);
        Console.WriteLine("\nmin: " + min);

        /*
            Collections in C#
            - Collections are classes that we can use to store a collection of objects.
            - Not limited to one type of object.
            - No size constraints; it can grow in size as we add more elements.

            - We use them to store, manage, and manipulate groups of objects more efficiently:
                > Adding
                > Deleting
                > Replacing
                > Searching
            
            - Non-generic vs. Generic Collections
                > Non-generic:
                    * Can store any type of object.
                    * Located in System.Collections namespace.
                > Generic:
                    * Limited to one type of object.
                    * Located in System.Collections.Generic namespace.
        */
        Console.WriteLine();
        int num1 = 7;
        float num2 = 3.14f;
        string name = "Sam";
        ArrayList arrayList1 = new ArrayList();
        arrayList1.Add(num1);
        arrayList1.Add(num2);
        arrayList1.Add(name);
        int counter = 0;
        foreach (object element in arrayList1) {
            Console.WriteLine("arrayList1[{0}]: {1}", counter, element);
            counter++;
        }

        Console.WriteLine();
        string car1 = "BMW";
        string car2 = "Honda";
        string car3 = "Audi";
        List<string> arrayList2 = new List<string>();
        arrayList2.Add(car1);
        arrayList2.Add(car2);
        arrayList2.Add(car3);
        counter = 0;
        foreach (string str in arrayList2) {
            Console.WriteLine("arrayList2[{0}]: {1}", counter, str);
            counter++;
        }

        /*
            ArrayLists
        */
        ArrayList myList = new ArrayList();
        myList.Add(7);
        myList.Add(11);
        myList.Add(89);
        myList.Add(65.67);
        myList.Add("Samuel");
        myList.Add('$');
        myList.Add(100);
        myList.Remove(3);
        Console.WriteLine("\nmyList.Count: " + myList.Count);
        double sum = 0;
        foreach (object obj in myList) {
            if (obj is int) {
                sum += Convert.ToDouble(obj);
            } else if (obj is double) {
                sum += (double) obj;
            } else if (obj is string) {
                Console.WriteLine(obj);
            }
        }
        Console.WriteLine("sum: " + sum);

        /*
            Lists
        */
        var numbersList = new List<int>();
        var numbersList2 = new List<int>{1, 5, 35, 100};
        int value = numbersList2[2];

        /*
            Hashtables
            - 1:1 relationships
            - (key, value) pair
            - different types
        */
        Hashtable studentsTable = new Hashtable();
        Student st1 = new Student(1, "Maria", 98);
        Student st2 = new Student(2, "Jason", 76);
        Student st3 = new Student(3, "Clara", 43);
        Student st4 = new Student(4, "Steve", 55);
        studentsTable.Add(st1.id, st1);
        studentsTable.Add(st2.id, st2);
        studentsTable.Add(st3.id, st3);
        studentsTable.Add(st4.id, st4);
        Student storedSt1 = (Student) studentsTable[1];
        Console.WriteLine("\nstoredSt1: " + storedSt1.name + " | " + storedSt1.gpa);
        Console.WriteLine("\nstudentsTable:");
        foreach (DictionaryEntry entry in studentsTable) {
            Student temp = (Student) entry.Value;
            Console.WriteLine("--> {0} | {1} | {2}", temp.id, temp.name, temp.gpa);
        }
        Console.WriteLine("\nstudentsTable:");
        foreach (Student std in studentsTable.Values) {
            Console.WriteLine("--> {0} | {1} | {2}", std.id, std.name, std.gpa);
        }

        /*
            Dictionaries
            - same data type for (key, value) pair.
        */
        Console.WriteLine();
        Dictionary<int, int> numsMap = new Dictionary<int, int>();
        int[] twoSumNums = {2, 7, 11, 15};
        int twoSumTarget = 9;
        for (int i = 0; i < twoSumNums.Length; i++) {
            int complement = twoSumTarget - nums[i];
            numsMap.Add(complement, i);
        }
        for (int i = 0; i < twoSumNums.Length; i++) {
            int complement = twoSumTarget - nums[i];
            if (numsMap.ContainsKey(complement) && (numsMap[complement] != i)) {
                Console.WriteLine("output: " + i + ", " + numsMap[complement]);
                break;
            }
        }
    }
    
    public static void paramsMethod(params string[] sentence) {
        Console.WriteLine();
        for (int i = 0; i < sentence.Length; i++) {
            Console.WriteLine("sentence[{0}]: {1}", i, sentence[i]);
        }
    }

    public static void paramsMethodv2(params object[] stuff) {
        Console.WriteLine();
        for (int i = 0; i < stuff.Length; i++) {
            Console.Write(stuff[i].ToString() + " ");
        }
        Console.WriteLine();
    }

    public static int minV2(params int[] numbers) {
        int min = int.MaxValue;
        foreach (int num in numbers) {
            if (num < min) {
                min = num;
            }
        }
        return min;
    }
}