/*
    Sami Munir
    smunir2001@gmail.com
    December 12th, 2023
    Rutgers University
    Data Structures & Algorithms Mastery
    - Linkedlist Queues: C#
*/

namespace Linkedlist_Queue;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Linkedlist Queues - C#");
        Console.WriteLine("----------------------\n");

        LLQueue ll_queue = new LLQueue();
        ll_queue.ToString();

        // testing function Enqueue()
        ll_queue.Enqueue(2);
        ll_queue.Enqueue(-11);
        ll_queue.Enqueue(65);

        // testing function Dequeue()
        ll_queue.Dequeue();
        ll_queue.Dequeue();
        ll_queue.Dequeue();
        ll_queue.Dequeue(); // ERROR expected --> null linkedlist removal
    }
}