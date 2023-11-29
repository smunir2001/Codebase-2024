public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("\nSimple Graph - Java");
        System.out.println("-------------------");

        Vertex v1 = new Vertex("Sami", 7);
        Vertex v2 = new Vertex("John", 2);
        Vertex v3 = new Vertex("Sabrina", 3); 

        Graph graph = new Graph();
        graph.printVertices();

        graph.addVertex(v1);
        graph.addVertex(v2);
        graph.addVertex(v3);
    }
}