namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(4);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.PrintMatrix();

            Console.WriteLine("Има ли ръб между 1 и 3"+graph.HasEdge(1, 3));
            Console.WriteLine("Има ли ръб между 2 и 3"+graph.HasEdge(2, 3));
        }
    }
}
