namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 4);

            Console.WriteLine("DFS from edge 0:");
            g.DFS(0);
            Console.WriteLine("\nBFS from edge 0:");
            g.BFS(0);

        }
    }
}
