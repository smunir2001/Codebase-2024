import java.util.LinkedList;

public class App {
    public static void main(String[] args) throws Exception {
        System.out.println("\nSimple Graph - Java");
        System.out.println("-------------------");

        Vertex v1 = new Vertex("Sami", 7);
        Vertex v2 = new Vertex("John", 2);
        Vertex v3 = new Vertex("Sabrina", 3);
        int numVertices = 3;
        
        LinkedList<Vertex> vertices_list = new LinkedList<Vertex>();
        vertices_list.add(v1);
        vertices_list.add(v2);
        vertices_list.add(v3);
        
        Vertex[] vertices = new Vertex[numVertices];
        for (int i = 0; i < vertices.length; i++) {
            vertices[i] = vertices_list.get(i);
        }

        Graph graph = new Graph(vertices);
        graph.printVertices();
    }
}