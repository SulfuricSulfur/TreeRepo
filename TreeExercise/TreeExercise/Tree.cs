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
        private Node root = null;
        private int numLevels;//the number of levels that the user has inputted

        //root value
        public Node Root
        {
            get { return root; }
        }
  
        /// <summary>
        /// for inserting a node into the tree
        /// </summary>
        /// <param name="data"></param>
        public void Insert(int data)
        {
            
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
