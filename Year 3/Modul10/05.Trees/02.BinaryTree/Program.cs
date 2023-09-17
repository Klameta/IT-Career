namespace _02.BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.Add(5);
            binaryTree.Add(7);
            binaryTree.Add(1);

            Console.WriteLine(binaryTree.Contains(4));
            Console.WriteLine(binaryTree.Contains(7));
        }
    }
}