/*
    Sami Munir
    November 30th, 2023
    My CS Projects
    NJ Transit Network (Graphs) - C#
*/
namespace nj_transit_network;
public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("NJ Transit Network");
        Console.WriteLine("------------------");

        Graph njtGraph = new Graph();
        njtGraph.ToString();

        njtGraph.AddVertex("Trenton Transit Center");
        njtGraph.AddVertex("Hamilton");
        njtGraph.AddVertex("Princeton Junction");
        njtGraph.AddVertex("Jersey Ave");
        njtGraph.AddVertex("New Brunswick");
        njtGraph.AddVertex("Edison");
        njtGraph.AddVertex("Metuchen");
        njtGraph.AddVertex("Metropark");
    }
}