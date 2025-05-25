namespace n_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }
        static int Factoriel(int n)
        {
            if (n==1||n==0)return 1;
            return n*Factoriel(n-1);
        }
    }
}
