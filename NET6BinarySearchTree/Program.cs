﻿namespace NET6BinarySearchTree
{
    /// <summary>
    /// This example shows how to implement a Binary Search Tree.
    /// A tree whose nodes have at most 2 child nodes is called a binary tree.
    /// We name them the left and right child because each node in a binary tree can have only 2 children.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            BinaryTree binaryTree = new BinaryTree();
 
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);
 
            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();
 
            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();
 
            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();
 
            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();
 
            binaryTree.Remove(7);
            binaryTree.Remove(8);
 
            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();
 
            Console.ReadLine();
        }
    }
}