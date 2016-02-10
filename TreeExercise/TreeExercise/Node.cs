using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Node
    {
        //attributes
        private Node left;//node to the left of the current node
        private Node right;//node to the right of the current node
        private int data;//the number being stored

        //the parent node
        private Node parent;

        //constructor
        //the node will take in a data value that corresponds to it
        public Node(int val)
        {
            data = val;
            left = null;
            right = null;
        }


        //properties
        public int Data
        {
            get { return data; }
        }
        public Node Left//this is for accessing the node of the left of the current one
        {
            get { return left; }
            set { left = value; }
        }
        public Node Right//this is for accessing the node to the right of the current one
        {
            get { return right; }
            set { right = value; }
        }
        public Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }


    }
}
