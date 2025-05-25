namespace Custom_Doubly_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            //Достъпване на елементи
            //Всеки свързан списък съдържа възли-Node
            //LinkedList
            //->node1(head)
            //->node2
            //->mode3
            // Всеки Node съдържа node.value=стойност и 
            // node.Next- референция към следващият елемент

            LinkedListNode<int> first=linkedList.First;
            Console.WriteLine(first.Value);
            Console.WriteLine(first.Next.Value);
            Console.WriteLine(first.Next.Next.Value);

            Console.WriteLine("-------------");

            //обхождане
            LinkedListNode<int> current = linkedList.First;
            while (current!=null)
            {
                Console.WriteLine(current.Value);
                current=current.Next;
            }
            

            //Двойно свързаният списък има head tail
            //дефоутният свързан списък в с шарп е двойно свързан
            //освен че има референзия към следващият
            //елемент има и рефернция към предишният
           //Previous
           //Add last-добавя в края на списъка
           //Add first-добавя в началото на списъка


        }
    }
}
