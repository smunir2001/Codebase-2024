public class Edge {
    private Vertex src;
    private Vertex dest;
    private float weight;

    public Edge() {}

    public Edge(Vertex src, Vertex dest) {
        this.src = src;
        this.dest = dest;
        this.weight = 1;
    }

    public Edge(Vertex src, Vertex dest, float weight) {
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

    public void setWeight(float weight) {
        this.weight = weight;
    }

    public float getWeight() {
        return this.weight;
    }

    @Override
    public String toString() {
        return "{ src: " + src.getData() + " dest: " + dest.getData() + " weight: " + weight + " }";
    }
}