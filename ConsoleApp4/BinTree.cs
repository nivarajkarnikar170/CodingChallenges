using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class BinTree
    {
        public Node root;

        // Tree Node
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int data)
            {
                this.data = data;
                this.left = null;
                this.right = null;
            }
        }

        // Function to insert nodes in level order
        public Node insertLevelOrder(int[] arr,
                                Node root, int i)
        {
            // Base case for recursion
            if (i < arr.Length)
            {
                Node temp = new Node(arr[i]);
                root = temp;

                // insert left child
                root.left = insertLevelOrder(arr,
                                root.left, 2 * i + 1);

                // insert right child
                root.right = insertLevelOrder(arr,
                                root.right, 2 * i + 2);
            }
            return root;
        }

        // Function to print tree
        // nodes in InOrder fashion
        public void inOrder(Node root)
        {
            if (root != null)
            {
                inOrder(root.left);
                Console.Write(root.data + " ");
                inOrder(root.right);
            }
        }

        public void findSumLeft(Node root, int sumleft)
        {
            
            if (root != null)
            {
                if (root.left != null) {
                    //sumleft = sumleft + findSumLeft(root.left, );
                }
                inOrder(root.left);
                Console.Write(root.data + " ");
                inOrder(root.right);
            }
        }

        // Driver code
        //public static void Main(String[] args)
        //{
        //    Tree t2 = new Tree();
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 6, 6, 6 };
        //    t2.root = t2.insertLevelOrder(arr, t2.root, 0);
        //    t2.inOrder(t2.root);
        //}
    }
}
