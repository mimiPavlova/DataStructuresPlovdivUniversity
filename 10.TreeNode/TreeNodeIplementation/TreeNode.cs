using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreeNodeIplementation
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int value)
        {
            this.Value = value;
            this.Right=null;
            this.Left=null;
        }


        public void Add(int value)
        {
         
            if (value<this.Value)
            {
                if (Left==null)
                {
                    this.Left=new TreeNode(value);
                }
                else
                {
                    this.Left.Add(value);
                }

            }

            else
            {
                if (this.Right==null)
                {
                  this.Right=new TreeNode(value);
                }
                else
                {
                    this.Right.Add(value);
                }
               
                
            }
        }
        public void Preorder(TreeNode node)
        { 
            if (node is null) return;
            Console.WriteLine(node.Value);
            Preorder(node.Left);
            Preorder(node.Right);

        }
        public void Inorder(TreeNode node)
        {
            if (node is null) return;
            Inorder(node.Left);
            Console.WriteLine(node.Value);
            Inorder(node.Right);
        }
        public void PostOrder(TreeNode node)
        {
            if (node is null) return;
            PostOrder(node.Left);         
            PostOrder(node.Right);
            Console.WriteLine(node.Value);

        }
    }

}
