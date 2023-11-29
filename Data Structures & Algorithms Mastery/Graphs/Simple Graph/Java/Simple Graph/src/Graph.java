import java.util.LinkedList;

public class Graph {
    private LinkedList<Vertex> graph;
    private int numVertices;
    private int numEdges;

    public Graph() {}

    private boolean isEmpty() {
        if (graph == null) {
            return true;
        } else {
            return false;
        }
    }

    private boolean containsVertex(Vertex targetVertex) {
        if (graph.contains(targetVertex)) {
            return true;
        } else {
            return false;
        }
    }
    
    public void addVertex(Vertex newVertex) {
        System.out.println("\naddVertex(" + newVertex.getData() + ") called...");
        if (isEmpty()) {
            graph = new LinkedList<Vertex>();
            graph.add(newVertex);
        } else {
            graph.add(newVertex);
        }
        numVertices++;
        printVertices();
    }

    public void removeVertex(Vertex vertexToRemove) {
        if (containsVertex(vertexToRemove)) {
            System.out.println("\nremoveVertex(" + vertexToRemove.getData() + ") called...");
            graph.remove(vertexToRemove);
        } else {
            System.out.println("\nremoveVertex() called...\n--<ERROR>-- vertex does not exist.");
        }
        printVertices();
    }

    public void printVertices() {
        // System.out.println("\nprintVertices() called...");
        if (isEmpty()) {
            System.out.println("--<EMPTY GRAPH>--");
        } else {
            for (int i = 0; i < this.graph.size(); i++) {
                System.out.println("Vertex " + (i + 1) + ". -->\n" + graph.get(i).toString());
            }
        }
    }
}