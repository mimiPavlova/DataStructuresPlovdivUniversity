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
    public void AddEdge(int i, int j)
    {
        if (i>=0 && j>=0&&i<numVertices&&j<numVertices)
        {
            adjacencyMatrix[i, j]=1;
            adjacencyMatrix[j, i]=1;
        }
        else throw new ArgumentOutOfRangeException("index out of range");

    }
    //Обхождане в широчина
    public void BFS(int start)
    {
        visited =new bool[numVertices];
        Queue<int>queue = new Queue<int>();

        visited[start] = true;
        queue.Enqueue(start);

        while (queue.Count>0)
        {
            int v = queue.Dequeue();
            Console.WriteLine(v+" ");
            for (int i = 0; i < numVertices; i++)
            {
                if (adjacencyMatrix[v, i]==1&&!visited[i])
                {
                    visited[i]=true;
                    queue.Enqueue(i);
                }
            }
        }
    }
    //Обхождане в дълбочина
    public void DFS(int strat)
    {
        visited=new bool[numVertices];
        DFSUntil(strat);

    }
   private void DFSUntil(int v)
    {
        visited[(int)v] = true;
        Console.WriteLine(v+" ");
        for (int i = 0; i < numVertices; i++)
        {
            if (adjacencyMatrix[v, i]==1&&!visited[i])
            {
                DFSUntil(i);
            }
        }
    }

}

