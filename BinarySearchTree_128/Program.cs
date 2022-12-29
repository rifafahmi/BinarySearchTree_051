using System;

namespace BinarySearchTree_051
{
    class Program
    {
        /*A node class consi
         * 
         */
        class node
        {
            public string info;
            public node lchild;
            public node rchild;
            //constructor for the node class

            public node(string i, node l, node r)
            {
                info = i;
                lchild = l;
                rchild = r;
            }
        }
        class BinaryTree
        {
            public node ROOT;
            public BinaryTree()
            {
                ROOT = null; // intializing root to null
            }
            public void insert(string element)// insert a node in the binary 
            {
                node tmp, parent = null, currentnode = null;
                find(element, ref parent, ref currentnode);
                if (currentnode != null) //
                {
                    Console.WriteLine("duplicate words not allowed");
                    return;
                }
            }
        }
    }
}

