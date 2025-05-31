using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo;

public class Dijkstra
{
    private static int MinDistance(int[] dist, bool[] visited, int V)
    {
        int min = int.MaxValue, minIndex = -1;
        for (int v = 0; v < V; v++)
        {
            if (visited[v]&&dist[v]<=min)
            {
                min = dist[v];
                minIndex = v;
                {

                }
            }

        }return minIndex;
    }
    public static void DijkstraAlgo(int[,]graph, int src, int V)
    {
        int[]dist=new int[V];//най-малки разстояния
        bool[] visited = new bool[V];//посетени върхове

        for (int i = 0; i < V; i++)
        {
            dist[i]=int.MaxValue;
            visited[i]=false;

        }
        for (int count = 0; count < V-1; count++)
        {
            int u = MinDistance(dist, visited, V);
            visited[u]=true;
            for (int v = 0; v < V; v++)
            {
               if (!visited[v]&&graph[u,v]!=0
                    &&dist[u]+graph[u, v]<dist[v])
                {
                    dist[v]=dist[u]+graph[u, v];
                }
            }
        }
        Console.WriteLine("Връх \t Разстояние от връх " + src);
        for (int i = 0; i <V; i++)
        {
            Console.WriteLine(i+" \t"+dist[i]);
        }
    }
}
