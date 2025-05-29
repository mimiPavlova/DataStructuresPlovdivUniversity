using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo;

public class Graph
{
    private int[,] adjacencyMatrix;
    private int numVertices;
    private bool[] visited;
    public Graph(int vertices)
    {
        this.numVertices=vertices;
        this.adjacencyMatrix=new int[vertices, vertices];
        visited = new bool[vertices];
    }
    private void AddEdge(int i, int j)
    {
        if (i>=0 && j>=0&&i<numVertices&&j<numVertices)
        {
            adjacencyMatrix[i, j]=1;
            adjacencyMatrix[j, i]=1;
        }
        else throw new ArgumentOutOfRangeException("index out of range");

    }
    //
}

