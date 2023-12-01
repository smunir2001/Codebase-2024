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
        njtGraph.AddVertex("Rahway");

        njtGraph.AddVertex("Avenel");
        njtGraph.AddVertex("Woodbridge");
        njtGraph.AddVertex("Perth Amboy");

        njtGraph.AddVertex("Newark Penn Station");
        njtGraph.AddVertex("New York Penn Station");
        njtGraph.AddVertex("Hoboken");

        njtGraph.AddEdge("Trenton Transit Center", "Hamilton", 5.1);
        njtGraph.AddEdge("Hamilton", "Princeton Junction", 5.4);
        njtGraph.AddEdge("Princeton Junction", "Jersey Ave", 9.7);
        njtGraph.AddEdge("Jersey Ave", "New Brunswick", 4.7);
        njtGraph.AddEdge("New Brunswick", "Edison", 3.2);
        njtGraph.AddEdge("Edison", "Metuchen", 4.1);
        njtGraph.AddEdge("Metuchen", "Metropark", 4.3);
        njtGraph.AddEdge("Metropark", "Rahway", 7.7);
        
        njtGraph.AddEdge("Rahway", "Newark Penn Station", 25.7);
        
        njtGraph.AddEdge("Rahway", "Avenel", 2.9);
        njtGraph.AddEdge("Avenel", "Woodbridge", 3.1);
        njtGraph.AddEdge("Woodbridge", "Perth Amboy", 3.3);

        njtGraph.AddEdge("Newark Penn Station", "New York Penn Station", 15.1);
        njtGraph.AddEdge("Newark Penn Station", "Hoboken", 12.0);

        // njtGraph.PrintGraph();

        njtGraph.BreadthFirstTraversal();
        njtGraph.DepthFirstTraversal();
    }
}