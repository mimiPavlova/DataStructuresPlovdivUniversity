using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList_Generic
{
    public class CustomGenericList<T>
    {

        public Node First {  get; set; }
        public Node Last { get; set; }

        public void AddFirst( T item)
        {
           
            if (item is null) throw new ArgumentNullException("item cannot be null"); 
            Node newNode = new Node(item);
            if (First == null) { First =Last = newNode; return; }
           
            newNode.Next = First;
            First.Previous = newNode; 
            First = newNode;


        }
        public void AddLast(T item)
        {
            if (item is null) throw new ArgumentNullException("item cannot be null");
            Node newNode = new Node(item);
            if (First == null) { First =Last = newNode; return; }
            newNode.Previous=Last;
            Last.Next=newNode;
            Last = newNode;


        }
        public void RemoveFirst()
        {
            if (First == null)
                throw new InvalidOperationException("list empty");
            if (First==Last)
            {
                First=Last=null; return;
            }
            First=First.Next;
            First.Previous=null;

        }
        public void RemoveLast()
        {
            if (First == null) throw new InvalidOperationException("List is empty");
            if (First==Last)
            {
                First=Last=null;return;
            }
            Last=Last.Previous;
            Last.Next=null;

        }
        public void ForEach(Action<T> action )
        {
            Node current=First;
            while(current != null )
            {
                action(current.Value);
                current=current.Next;
            }
        }
        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public Node(T value)
            {
                Value = value;
            }
        }
    }
}
