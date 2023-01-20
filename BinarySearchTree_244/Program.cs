using BinarySearchTree_244;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");

            //BinarySearchTreeBuilder<int> binarySearchTree = new BinarySearchTreeBuilder<int>(56);
            //binarySearchTree.Insert(30);
            //binarySearchTree.Insert(70);
            //binarySearchTree.Display();

            BinarySearchTreeBuilder<int> binarySearchTree = new BinarySearchTreeBuilder<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);

            Console.WriteLine("======Binary Tree elements are======");
            binarySearchTree.Display();
            Console.WriteLine();
            Console.WriteLine("Enter a number u want to search");
            int element = Convert.ToInt32(Console.ReadLine());
            bool result = binarySearchTree.Search(element, binarySearchTree);
        }
    }
}

