using System;
namespace Learning.Algorithms.Graphs
{
    // G = (V, E)

    // G = Graph
    // V = vertex set
    // E = edges set
    public class Graph
    {

        public void AppendEdge(int x, int y)
        {
            adjacency[x, y] = 1;
        }

        public int Size { get; private set; }

        public Graph(int nodes)
        {
            Size = nodes;
            adjacency = new int[nodes, nodes];
        }

        private readonly int[,] adjacency;

    }
}
