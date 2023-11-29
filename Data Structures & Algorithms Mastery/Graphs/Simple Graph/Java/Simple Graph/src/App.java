public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("\nSimple Graph - Java");
        System.out.println("-------------------");

        Vertex v1 = new Vertex("Sami", 7);
        Vertex v2 = new Vertex("John", 2);
        Vertex v3 = new Vertex("Sabrina", 3);
        Vertex v4 = new Vertex("Mary", 4);

        Graph graph = new Graph();
        graph.printVertices();

        graph.addVertex(v1);
        graph.addVertex(v2);
        graph.addVertex(v3);
        graph.addVertex(v4);

        graph.removeVertex(v3);
    }
}