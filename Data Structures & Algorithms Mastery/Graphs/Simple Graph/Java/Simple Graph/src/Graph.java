import java.util.LinkedList;

public class Graph {
    private LinkedList<Vertex> graph;
    private LinkedList<Edge> edges = new LinkedList<Edge>();
    private int numVertices;
    private int numEdges;

    public Graph() {
        System.out.println("\nGraph initialization successful.");
        printGraphDS();
    }

    private boolean isEmpty() {
        if (graph == null) {
            return true;
        } else {
            return false;
        }
    }

    private boolean containsVertex(Vertex targetVertex) {
        if (!isEmpty() && graph.contains(targetVertex)) {
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
        printGraphDS();
    }

    public void removeVertex(Vertex vertexToRemove) {
        if (!isEmpty() && containsVertex(vertexToRemove)) {
            System.out.println("\nremoveVertex(" + vertexToRemove.getData() + ") called...");
            graph.remove(vertexToRemove);
            numVertices--;
        } else if (!isEmpty()) {
            System.out.println("\nremoveVertex() called...\n--<ERROR>-- vertex does not exist.");
        } else {
            System.out.println("\nremoveVertex() called...\n--<ERROR>-- graph is empty.");
        }
        printGraphDS();
    }

    public void addEdge(Vertex src, Vertex dest, float weight) {
        if (containsVertex(src) && containsVertex(dest)) {
            System.out.println("\naddEdge(" + src.getData() + " <-> " + dest.getData() + ") called...");
            edges.add(new Edge(src, dest, weight));
            edges.add(new Edge(dest, src, weight));
            this.graph.get(src.getKey()).addNeighbor(new Edge(src, dest, weight));
            this.graph.get(dest.getKey()).addNeighbor(new Edge(dest, src, weight));
            numEdges++;
        } else if (!isEmpty()) {
            System.out.println("\naddEdge() called...\n--<ERROR>-- vertices DNE, cannot add edge.");
        } else {
            System.out.println("\naddEdge() called...\n--<ERROR>-- graph is empty.");
        }
        printGraphDS();
    }

    public void printGraphDS() {
        if (isEmpty()) {
            System.out.println("--<EMPTY GRAPH>--");
        } else {
            for (int i = 0; i < this.graph.size(); i++) {
                System.out.println("\tVertex " + (i + 1) + ". -->\n" + graph.get(i).toString());
            }
        }
        System.out.println("\tnumVertices: " + numVertices + "\n\tnumEdges: " + numEdges);
    }
}