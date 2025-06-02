using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedStack_Generic;

public class CustomGenericStack_Linked<T>
{
    public Node Top {  get; set; }

    private int _count = 0;

    public void Push(T value)
    {
        Node newNode = new Node(value);
        newNode.Previous=Top;
        Top = newNode;
        _count++;
    }
    public T Pop()
    {
        EnsureNotEmpty();
        T removed=Top.Value;
        Top=Top.Previous;
        return removed;
    }
    public T Peek()
    {
        EnsureNotEmpty();
        return Top.Value;
    }
    public void ForEach(Action<T> action)
    {
        EnsureNotEmpty();
        Node current = Top;
        while (current != null)
        {
            action(current.Value);
            current = current.Previous;
        }
    }
    private void EnsureNotEmpty()
    {
        if(_count ==0)
        {
            throw new ArgumentException("stack empty");

        }
    }
    
    public class Node
    {
        public T Value;
        public Node Previous {  get; set; }
        public Node(T value) { Value=value; }
    }
}
