public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("\nSimple Graph - Java");
        System.out.println("-------------------");

        Vertex v1 = new Vertex("Alpha", 0);
        Vertex v2 = new Vertex("Bravo", 1);
        Vertex v3 = new Vertex("Charlie", 2);
        Vertex v4 = new Vertex("Delta", 3);
        Vertex v5 = new Vertex("Echo", 4);

        Graph graph = new Graph();

        graph.addVertex(v1);
        graph.addVertex(v2);
        graph.addEdge(v1, v2, 10.0f);
        graph.addVertex(v3);
        graph.addEdge(v1, v3, 7.0f);
        graph.addVertex(v4);
        graph.addEdge(v1, v4, 5.0f);
    }
}