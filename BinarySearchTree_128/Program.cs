﻿using System;

namespace BinarySearchTree_128
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
        
    }
