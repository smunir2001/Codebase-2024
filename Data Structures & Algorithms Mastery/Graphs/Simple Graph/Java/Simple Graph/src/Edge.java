public class Edge {
    Vertex src;
    Vertex dest;
    int weight;

    public Edge() {}

    public Edge(Vertex src, Vertex dest) {
        this.src = src;
        this.dest = dest;
        this.weight = 1;
    }

    public Edge(Vertex src, Vertex dest, int weight) {
        this.src = src;
        this.dest = dest;
        this.weight = weight;
    }

    public void setSrc(Vertex src) {
        this.src = src;
    }

    public Vertex getSrc() {
        return this.src;
    }

    public void setDest(Vertex dest) {
        this.dest = dest;
    }

    public Vertex getDest() {
        return this.dest;
    }

    public void setWeight(int weight) {
        this.weight = weight;
    }

    public int getWeight() {
        return this.weight;
    }
}