public class Graph {
    private Vertex[] graph;
    private int numVertices;
    private int numEdges;

    public Graph() {}

    public Graph(Vertex[] vertices) {
        this.graph = vertices;
        this.numVertices = vertices.length;
    }

    public void printVertices() {
        System.out.println("\nprintVertices() called...");
        System.out.println("data | key | neighbors");
        System.out.println("----------------------");
        for (int i = 0; i < graph.length; i++) {
            System.out.println((i + 1) + ". " + graph[i].toString());
        }
    }
}