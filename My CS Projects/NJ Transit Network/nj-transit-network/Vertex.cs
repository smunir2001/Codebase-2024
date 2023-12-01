namespace nj_transit_network;

public class Vertex {
    private string data;
    List<Edge> neighbors;

    public Vertex() {
        this.data = "N/A";
        this.neighbors = new List<Edge>();
    }

    public Vertex(string data) {
        this.data = data;
        this.neighbors = new List<Edge>();
    }

    /*
        Helper function HasNeighbors()
    */
    private Boolean HasNeighbors() {
        if (this.neighbors.Count == 0) {
            return false;
        } else {
            return true;
        }
    }

    public void SetData(string data) {
        this.data = data;
    }

    public string GetData() {
        return this.data;
    }

    public void AddNeighbor(Edge neighbor) {
        this.neighbors.Add(neighbor);
    }

    public void RemoveNeighbor(Edge neighbor) {
        this.neighbors.Remove(neighbor);
    }

    override public string ToString() {
        Console.WriteLine(this.data + " -->");
        string neighborsStr = "";
        for (int i = 0; i < this.neighbors.Count; i++) {
            neighborsStr += this.neighbors[i].GetDest().GetData() + ", ";
        }
        if (this.HasNeighbors()) {
            Console.WriteLine("\tNeighbors: { " + neighborsStr + " }.");
        } else {
            Console.WriteLine("\tNeighbors: { }.");
        }
        Console.WriteLine("\tnumNeighbors: " + this.neighbors.Count);
        return "";
    }
}