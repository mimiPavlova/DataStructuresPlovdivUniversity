using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Graph
    {
        private int[,] adjacencyMatrix;
        private int numVertices;

        public Graph(int vertices)
        {
            numVertices=vertices;
            adjacencyMatrix=new int[vertices, vertices];

        }
        
        public void AddEdge(int i, int j)
        {
            if (i>=0&&i<numVertices&&j>=0&&j<numVertices)
            {
                adjacencyMatrix[i, j]=1;
                adjacencyMatrix[j, i]=1;
            }

        }
        public void RemoveEdge(int i, int j)
        {
            if (i>=0&&i<numVertices&&j>=0&&j<numVertices)
            {
                adjacencyMatrix[i, j]=0;
                adjacencyMatrix[j, i]=0;

            }

        }
        public bool HasEdge(int i, int j)
        {
            return adjacencyMatrix[i, j]==1;

        }
        public void PrintMatrix()
        {
            Console.WriteLine("Матрица на съседствата:");

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                  Console.Write(adjacencyMatrix[i,j]+" ");
                }
            }
            Console.WriteLine();
        }

    
}
