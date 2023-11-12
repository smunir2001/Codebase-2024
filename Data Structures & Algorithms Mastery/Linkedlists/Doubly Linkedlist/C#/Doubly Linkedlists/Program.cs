/*
    Sami Munir
    smunir2001@gmail.com
    November 11, 2023
    Rutgers University
    Data Structures & Algorithms Mastery
    - Doubly linkedlists: C#
*/
namespace Doubly_Linkedlists;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Doubly Linkedlists - C#");
        Console.WriteLine("-----------------------\n");

        DoublyLinkedlist dll_one = new DoublyLinkedlist();
        dll_one.ToString();

        // testing function InsertFirst()
        dll_one.InsertFirst(2);
        dll_one.InsertFirst(-11);
        dll_one.InsertFirst(65);

        // testing function RemoveFirst()
        dll_one.RemoveFirst();
        dll_one.RemoveFirst();
        dll_one.RemoveFirst();
        dll_one.RemoveFirst(); // ERROR expected --> null linkedlist removal

        // testing function InsertLast()
        dll_one.InsertLast(2);
        dll_one.InsertLast(-11);
        dll_one.InsertLast(65);
    }
}