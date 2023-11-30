public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("\nSimple Graph - Java");
        System.out.println("-------------------");

        /*Vertex v1 = new Vertex("Alpha", 0);
        Vertex v2 = new Vertex("Bravo", 1);
        Vertex v3 = new Vertex("Charlie", 2);
        Vertex v4 = new Vertex("Delta", 3);
        Vertex v5 = new Vertex("Echo", 4);
        Vertex v6 = new Vertex("Zulu", 5);

        Graph graph = new Graph();

        graph.addVertex(v1);
        graph.addVertex(v2);
        graph.addVertex(v3);
        graph.addVertex(v4);
        graph.addVertex(v5);
        graph.addVertex(v6);
        graph.addEdge(v1, v2, 10.0f);
        graph.addEdge(v1, v3, 7.0f);
        graph.addEdge(v1, v4, 5.0f);
        graph.addEdge(v3, v6, 25.0f);
        graph.addEdge(v4, v5, 17.0f);

        graph.toString();

        graph.breadthFirstTraversal();*/

        Graph graphV2 = new Graph();
        Vertex v1 = new Vertex("A", 0);
        Vertex v2 = new Vertex("B", 1);
        Vertex v3 = new Vertex("C", 2);
        Vertex v4 = new Vertex("D", 3);
        Vertex v5 = new Vertex("E", 4);
        Vertex v6 = new Vertex("F", 5);
        graphV2.addVertex(v1);
        graphV2.addVertex(v2);
        graphV2.addVertex(v3);
        graphV2.addVertex(v4);
        graphV2.addVertex(v5);
        graphV2.addVertex(v6);
        graphV2.addEdge(v1, v2, 1);
        graphV2.addEdge(v1, v3, 1);
        graphV2.addEdge(v2, v4, 1);
        graphV2.addEdge(v2, v5, 1);
        graphV2.addEdge(v3, v5, 1);
        graphV2.addEdge(v4, v5, 1);
        graphV2.addEdge(v4, v6, 1);
        graphV2.addEdge(v5, v6, 1);
        graphV2.breadthFirstTraversal();
        graphV2.depthFirstTraversal();
    }
}