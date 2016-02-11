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
        public List<Node> parentNodes;
        public List<Node> childrenNodes;//the nodes (left and right) of the parent

        public Tree(int levels)
        {
            numLevels = levels;//setting up the amount of levels there will be
            root = new Node(1);//starting by setting the root to have a default value of 1
            parentNodes = new List<Node>();
            childrenNodes = new List<Node>();
        }

        //root value
        public Node Root
        {
            get { return root; }
        }
  

        public void Insert()
        {

        }

        /// <summary>
        /// for inserting a node into the tree
        /// </summary>
        private void Insert(int data, Node currentNode )
        {

            //setting up for loop for the amount of levels


            for (int k=0; k < parentNodes.Count; k++)
            {
                if(parentNodes[k-1]==null)//if there is nothing to the left of the current node
                {

                }
            }


            /*
            for (int i =0; i < numLevels; i++)
            {
                //List<Node> parentNodes = new List<Node>();
        
                //this is for the amount of nodes on each level
                for(int j =1; j < (2^(j-1));j++)
                {
                    //creating an array of nodes that will hold all the nodes on that current level
                    int slots = (2 ^ (j - 1)) + 2;//the number of slots in the array
                    Node[] levelNodesC = new Node[slots];//the reason for the +2 is for the 0's at index 0 and at the very last index (acting like there is nothing to the left or right)
                    levelNodesC[0] = new Node(0);//adding a node with value of 0 to first spot
                    levelNodesC[slots-1] = new Node(0);//adding a node with value of 0 to last spot

                    for(int f=0; f< levelNodesC.Length -1; f++)
                    {

                    }
                    

                }
                */
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
