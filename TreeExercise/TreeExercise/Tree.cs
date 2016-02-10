using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    //binary tree
    class Tree
    {

        //attributes
        private Node root;
        private int numLevels;//the number of levels that the user has inputted

        public Tree(int levels)
        {
            numLevels = levels;//setting up the amount of levels there will be
            root = new Node(1);//starting by setting the root to have a default value of 1
        }

        //root value
        public Node Root
        {
            get { return root; }
        }
  
        /// <summary>
        /// for inserting a node into the tree
        /// </summary>
        public void Insert()
        {
            Node currNode = null;//this is the current node that is being addressed.

            //setting up for loop for the amount of levels
            for(int i =0; i < numLevels; i++)
            {
                //this is for the amount of nodes on each level
                for(int j =1; i < (2^(j-1));j++)
                {

                }

            }

        }

        /// <summary>
        /// used for going through and finding the next node to the right. The node listed will be the first node the traverse will start at
        /// (will be set to the root)
        /// </summary>
        /// <param name="node"></param>
        public void Traverse(Node node)
        {
            if(node != null)
            {

            }
        }


    }
}
