namespace nj_transit_network;

public class Edge {
    private Vertex src;
    private Vertex dest;
    private double weight;

    public Edge(Vertex src, Vertex dest) {
        this.src = src;
        this.dest = dest;
        this.weight = 1.0;
    }

    public Edge(Vertex src, Vertex dest, double weight) {
        this.src = src;
        this.dest = dest;
        this.weight = weight;
    }

    public void SetSrc(Vertex src) {
        this.src = src;
    }

    public Vertex GetSrc() {
        return this.src;
    }

    public void SetDest(Vertex dest) {
        this.dest = dest;
    }

    public Vertex GetDest() {
        return this.dest;
    }

    public void SetWeight(double weight) {
        this.weight = weight;
    }

    public double GetWeight() {
        return this.weight;
    }

    override public string ToString() {
        return this.src + " -(" + this.weight + ")> " + this.dest;
    }
}