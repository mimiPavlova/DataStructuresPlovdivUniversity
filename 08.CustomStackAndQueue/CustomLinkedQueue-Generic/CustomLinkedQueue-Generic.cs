using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedQueue_Generic;

public class CustomLinkedQueue_Generic<T>
{
    private Node Head, Tail;
    private int _count;
    public void Enqueue(T item)
    {
        Node newNode=new Node(item);
        if(Head==null) {Head=Tail=newNode;}
        else
        {
          Tail.Next=newNode;
        Tail=newNode;
        }
         
        _count++;
    }
    public T Dequeue()
    {
        EnsureNotEmpty();
        T value=Head.Value;
        if (_count==1)
        {
            Head=Tail=null;
        }
        else
        {
            Node next = this.Head.Next;
            Head = next;
        }
        _count--;
        return value;
    }
    public T Peek()
    {
        EnsureNotEmpty();
        return Head.Value;
    }
    public void ForEach(Action<T> action)
    {
        EnsureNotEmpty();
        Node curent=Head;
        while (curent != null)
        {
            action(curent.Value);
            curent=curent.Next;

        }
    }
    private void EnsureNotEmpty() 
    {
        if (_count==0)
        {
            throw new IndexOutOfRangeException("queue empty");
        }
    }


    private class Node
    {
     public T Value { get; set; }
        public Node Next { get; set; }
        public Node(T value)
        {
            Value = value;
        }
    }

}
