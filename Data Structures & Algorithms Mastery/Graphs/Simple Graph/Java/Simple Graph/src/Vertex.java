public class Vertex {
    private String data;
    private int key;

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
}