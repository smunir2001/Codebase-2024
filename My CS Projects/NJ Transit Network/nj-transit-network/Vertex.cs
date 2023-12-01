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

    public void SetData(string data) {
        this.data = data;
    }

    public string GetData() {
        return this.data;
    }

    override public string ToString() {
        return this.data;
    }

    public void AddNeighbor(Edge neighbor) {
        this.neighbors.Add(neighbor);
    }

    public void RemoveNeighbor(Edge neighbor) {
        this.neighbors.Remove(neighbor);
    }
}