using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public  class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;
        public BinaryTreeNode(int value)
        {
            Value = value;
            Left=null;
            Right=null;
        }
        public void Add(int value)
        {
            if (value<this.Value)
            {
                if (this.Left==null) this.Left=new BinaryTreeNode(value);   
                else this.Left.Add(value);          
            }
            else
            {
                if (this.Right==null) this.Right=new BinaryTreeNode(value);
                else this.Right.Add(value);
            }

            
        }
        public void Preorder(BinaryTreeNode node)
        {
            if (node is null) return;
            Console.WriteLine(node.Value);
            Preorder(node.Left);
            Preorder(node.Right);
        }
        public void Inorder(BinaryTreeNode node)
        {
            if (node is null) return;
           Inorder(node.Left);
            Console.WriteLine(node.Value);
           Inorder(node.Right );

        }
        public void Postorder(BinaryTreeNode node)
        {
            if (node is null) return;
            Postorder(node.Left);
            Console.WriteLine(node.Value);
            Postorder(node.Right );
        }
        public bool Search(BinaryTreeNode node, int target)
        {
            if(node is null)return false;
            if(node.Value==target)return true;
            if (target<node.Value) 
                return Search(node.Left, target); 
            else 
                return Search(node.Right, target);

        }

    }
}
