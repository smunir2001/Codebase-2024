import java.util.Arrays;
import java.util.LinkedList;

public class Vertex {
    private String data;
    private int key;
    private LinkedList<Vertex> neighbors = new LinkedList<Vertex>();

    public Vertex() {}

    public Vertex(String data) {
        this.data = data;
    }

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

    public void setKey(int key) {
        this.key = key;
    }

    public int getKey() {
        return this.key;
    }

    public LinkedList<Vertex> getNeighbors() {
        return this.neighbors;
    }

    @Override
    public String toString() {
        return "\tData: {" + this.data + "} | Key: {" + this.key + "}\n\tNeighbors: " + Arrays.toString(this.neighbors.toArray());
    }
}