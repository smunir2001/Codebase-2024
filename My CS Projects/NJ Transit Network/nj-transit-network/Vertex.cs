namespace nj_transit_network;

public class Vertex {
    private string data;

    public Vertex() {}

    public Vertex(string data) {
        this.data = data;
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
}