namespace nj_transit_network;
using System.Collections.Generic;

public class Graph {
    private List<Vertex> vertices;
    private int numVertices;
    private int numEdges;

    public Graph() {
        this.vertices = new List<Vertex>();
        this.numVertices = 0;
        this.numEdges = 0;
    }

    override public string ToString() {
        Console.WriteLine("NJ Transit Network -->");
        Console.WriteLine("\t" + this.vertices.ToString() + "\n\tvertices: " + this.numVertices + "\n\tedges: " + this.numEdges);
        return "";
    }
}