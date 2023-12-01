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

    /*
        Helper function GetVertexIndexFromName(string data)
    */
    private int GetVertexIndexFromName(string data) {
        for (int i = 0; i < this.vertices.Count; i++) {
            if (vertices[i].GetData().Equals(data)) {
                return i;
            }
        }
        return -1;
    }

    /*
        Helper function ReturnVertexNamesString()
    */
    private string ReturnVertexNamesString() {
        string result = "";
        for (int i = 0; i < this.vertices.Count; i++) {
            result += this.vertices[i].GetData() + ", ";
        }
        return result;
    }

    /*
        Helper function IsEmpty()
    */
    private Boolean IsEmpty() {
        if (this.vertices.Count == 0) {
            return true;
        } else {
            return false;
        }
    }

    public void AddVertex(string data) {
        Console.WriteLine("\nSuccessfully adding new vertex: { " + data + " }.");
        this.vertices.Add(new Vertex(data));
        this.numVertices++;
        this.ToString();
    }

    public void RemoveVertex(string data) {
        if (IsEmpty()) {
            Console.WriteLine("\n--<ERROR>-- cannot remove vertex: { " + data + " } from empty graph.");
        } else {
            int vertexIndex = GetVertexIndexFromName(data);
            if (vertexIndex == -1) {
                Console.WriteLine("\n--<ERROR>-- vertex: { " + data + " } does not exist in graph.");
            } else {
                Console.WriteLine("\nSuccessfully removing vertex: { " + data + " }.");
                this.vertices.RemoveAt(vertexIndex);
                this.numVertices--;
            }
        }
        this.ToString();
    }

    public void AddEdge(Vertex src, Vertex dest, double weight) {}

    override public string ToString() {
        Console.WriteLine("NJ Transit Network -->");
        if (IsEmpty()) {
            Console.WriteLine("\tVertices --> { }");
        } else {
            Console.WriteLine("\tVertices --> { " + ReturnVertexNamesString() + "\b\b }");
        }
        Console.WriteLine("\tvertices: " + this.numVertices + "\n\tedges: " + this.numEdges);
        return "";
    }
}