namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedList<int>linkeList= new LinkedList<int>();
            linkeList.AddLast(1);
            linkeList.AddLast(2);
            linkeList.AddLast(3);
            linkeList.AddLast(4);

            linkeList.AddFirst(5);
            Console.WriteLine(linkeList.First.Value);
            Console.WriteLine(linkeList.Last.Value);
            Console.WriteLine("Обхождане от ляво на дясно");
            Console.WriteLine("---------------------");
            LinkedListNode<int> current=linkeList.First;
            while (current!=null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Обхождане от дясно на ляво");
            LinkedListNode<int> second = linkeList.Last;
            while (second!=null)
            {
                Console.WriteLine(second.Value);
                second=second.Previous;
            }
            linkeList.Remove(5);
            //Remove метода обхожда всеки един
            //елемент, проверява дали е търсения
            //и ако е го премахва
            Console.WriteLine("-----------------");
            Console.WriteLine("премахване на числото 5");
            LinkedListNode<int>third=linkeList.First;
            while (third!=null)
            {
                Console.WriteLine(third.Value);
                third=third.Next;
            }
            //Забележка: При извикването на next и previous
            //се променя възела- node

            //Свързаният списък съществува главно заради бързина
            //Remone->n операции, n=list.Lenght
            //RemoveFirst- 1 операция
            //RemoveLat- 1 операция

            //Свързаният списък работи по-бързо при премахването и добавянето на 
            //елементи от обикновеният
            linkeList.Contains(11);
            //-поддържа и Contains метод
       
    }
}
