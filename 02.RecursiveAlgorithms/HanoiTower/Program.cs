namespace HanoiTower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hanoi(3, 'A', 'C', 'B');
        }
        static void Hanoi(int n,char start, char end, char mid )
        {
            if (n==1)
            {
                Console.WriteLine($"Move disk 1 from {start} to {end}");
                return;
            }

            //move n-1 disks to mid
            Hanoi(n-1, start, mid, end);

            //move n disk from start to end
            Console.WriteLine($"Move disk {n} from {start} to {end}");

            //move n-1 disks from mid to end
            Hanoi(n-1, mid, end, start);
        }
    }
}
