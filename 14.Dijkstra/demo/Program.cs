using System.IO.Pipes;

namespace demo;

internal class Program
{
    int[,] graph = {
            { 0, 4, 1, 0 },
            { 4, 0, 2, 3 },
            { 1, 2, 0, 5 },
            { 0, 3, 5, 0 }
        };


    Dijkstra dijkstra = new Dijkstra();
    
}

 

