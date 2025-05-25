namespace TreeNodeIplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10);
            Random random = new Random();
            for (int i = 0; i <15; i++)
            {
                root.Add(random.Next(0,20));
            }
            Console.WriteLine("-------Preorder--------");
            root.Preorder(root);


        }



    }
}
