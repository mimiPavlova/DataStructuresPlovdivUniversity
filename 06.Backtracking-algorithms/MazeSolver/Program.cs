namespace MazeSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] maze =
            {
                {1, 0, 1, 1 },
                {1, 1, 1, 0 },
                {0, 1, 0, 1 },
                {1, 1, 1, 1, }
            };
            int n=maze.GetLength(0);
            bool[,] visited = new bool[n,n];
            if(!SolveMaze(0, 0, maze, visited))
            {
                Console.WriteLine("Нама път от началото до края.");
            }

        }
        static bool SolveMaze(int x, int y, int[,]maze, bool[,] visited)
        {
            int n=maze.GetLength(0);
            if (x<0||y<0||y>=n||maze[x, y]==0||visited[x, y])
                return false;

            visited[x, y]=true;
            if (x==n-1&&y==n-1)
            {
                Console.WriteLine($"Крайна точка достигната при ({x} {y})");
                return true;
            }

            //Движения: надясно, надолу, налаво, нагоре

            int[] dx = { 0, 1, 0, -1 };  
            int[] dy = { 1, 0, -1, 0 };  

            for (int i = 0; i < 4; i++)
            {
                int newX = x+dx[i];
                int newY=y+dy[i];
                if(SolveMaze(newX, newY, maze, visited))
                {
                    Console.WriteLine($"Част от пътя ({x}, {y}) ");
                    return true;
                }

            }
            visited[x, y]=false;
            return false;


        }
    }
}
