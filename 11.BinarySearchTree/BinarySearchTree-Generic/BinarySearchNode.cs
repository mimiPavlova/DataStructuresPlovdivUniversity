using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Generic;

public  class BinarySearchNode<T> where T:IComparable<T>
{
    public T Value { get; set; }
    public BinarySearchNode<T> Left {  get; private set; }
    public BinarySearchNode<T> Right {  get; private set; }

    public void Add(T value)
    {
        if(value.CompareTo(Value) < 0)
        {
            if (Left == null) { Left=new BinarySearchNode<T> { Value = value }; }
            else
            {
                Left.Add(value);
            }
        }
        else
        {
            if (Right==null)
            {
                Right=new BinarySearchNode<T> {Value = value};
            }
            else
            {
                Right.Add(value);
            }
        }
    }

    public void Preorder()
    {
        Console.WriteLine(Value);
        Left?.Preorder();
        Right?.Preorder();
    }
    public void Inorder()
    {
        Left?.Inorder();
        Console.WriteLine(Value);
        Right?.Inorder();
    }
    public void PostOrder()
    {
        Left?.PostOrder();
        Right?.PostOrder();
        Console.WriteLine(Value);
    }

    public bool Search(T target)
    {
        int comparison=target.CompareTo(Value);
        if(comparison == 0)return true;
        if (comparison<0)
        {
            return Left?.Search(target) ?? false;
        }
        else
        {
            return Right?.Search(target) ?? false;
        }
      
        
    }

}
