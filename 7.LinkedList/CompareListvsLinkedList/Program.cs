using System.Diagnostics;

namespace CompareListvsLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compare AffFirst vs LinkedList;
            int n = 100_000;
            Stopwatch watch = Stopwatch.StartNew();
            List<int>list=new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Insert(0, i);
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed);

         
            Console.WriteLine("---------");   
            watch=Stopwatch.StartNew();
            LinkedList<int>linkedList=new LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                linkedList.AddFirst(i);
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            //работи около сто пъти по-бързо
        }
    }
}
