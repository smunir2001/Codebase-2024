import java.util.Arrays;
import java.util.LinkedList;

public class Vertex {
    private String data;
    private int key;
    private LinkedList<Edge> neighbors = new LinkedList<Edge>();

    public Vertex() {}

    public Vertex(String data, int key) {
        this.data = data;
        this.key = key;
    }

    public void setData(String data) {
        this.data = data;
    }

    public String getData() {
        return this.data;
    }

    public int getKey() {
        return this.key;
    }

    public void addNeighbor(Edge edge) {
        this.neighbors.add(edge); 
    }

    public LinkedList<Edge> getNeighbors() {
        return this.neighbors;
    }

    @Override
    public String toString() {
        return "\t\t{ Data: " + this.data + " Key: " + this.key + " }\n\t\t{ Neighbors: " + Arrays.toString(this.neighbors.toArray()) + " }";
    }
}