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
        public List<Node> parentNodes;
        public List<Node> childrenNodes;//the nodes (left and right) of the parent


        public Tree()
        {
            root = new Node(1);//starting by setting the root to have a default value of 1
            parentNodes = new List<Node>();//current level of nodes
            childrenNodes = new List<Node>();//next level of nodes
        }

        //root value
        public Node Root
        {
            get { return root; }
        }
  

        /*
        /// <summary>
        /// This will be the insert method that will be called initially in the main program.
        /// Will see if there is neighbor nodes. If not will pass the data of parent node .
        /// </summary>
        public void Insert(int numLevels)//the number of levels there will be
        {
            for(int i =0; i < numLevels; i++)//level 0 is first level
            {
                if(i == 0)//the first level, the root only for now
                {
                    parentNodes.Add(root);
                }
                else if (i > 0)
                {
                    Insert();//if there is multiple levels, start at root and make way down
                }
                
            }
        }
        */

        /// <summary>
        /// for inserting a node into the tree
        /// </summary>
        public void Insert(int levels)
        {
            for (int i = 1; i < levels; i++)//level 0 is first level
            {
                //setting up for loop for the amount of levels
                if (i == 1)//if the first node in the list.(only the root)
                {
                    parentNodes.Add(root);
                }
                for (int k = 0; k < parentNodes.Count; k++)
                {
                   
                    if (parentNodes.Count == 1)
                    {
                        parentNodes[k].Left = new Node(parentNodes[k].Data);//setting the left and right node of the root to the data of the root
                        parentNodes[k].Right = new Node(parentNodes[k].Data);
                    }
                    else if (k == 0)//if there is nothing to the left of the current node. The first node
                    {
                        //if there is only the root node


                        parentNodes[k].Left = new Node(parentNodes[k].Data);//setting the new node's data (one at leftmost end) to parent's data
                        int rightData = parentNodes[k].Data + parentNodes[k + 1].Data;//adding the parent and right neighbor's data together
                        parentNodes[k].Right = new Node(rightData);
                    }
                    else if (k == parentNodes.Count - 1)//if node is the rightmost one. (the last node in the list)
                    {
                        parentNodes[k].Right = new Node(parentNodes[k].Data);
                        int leftData = parentNodes[k].Data + parentNodes[k - 1].Data;//adding the rightmost one's data and the one to the left of that one together
                        parentNodes[k].Left = new Node(leftData);
                    }
                    else//for the middle nodes
                    {
                        int leftData = parentNodes[k].Data + parentNodes[k - 1].Data;//adding the parent and the left neighbord(left value)
                        int rightData = parentNodes[k].Data + parentNodes[k + 1].Data;//adding the parent and right neighbor's data together
                                                                                      //setting the left and right values of the children
                        parentNodes[k].Left = new Node(leftData);
                        parentNodes[k].Right = new Node(rightData);

                       // Traverse(parentNodes[k]);
                    }

                    childrenNodes.Add(parentNodes[k].Left);//adding the children nodes to the children list. Goes from left to right(left and right of one parent, then left and right of the other
                    childrenNodes.Add(parentNodes[k].Right);
                }

                //replacing the parents with the children.
                //making the children the new parents
                parentNodes.Clear();//clearing the parent node list
                for(int j =0; j<childrenNodes.Count; j++)
                {
                    if (j < parentNodes.Count)
                    {
                        parentNodes[j] = childrenNodes[j];
                    }
                    else
                    {
                        parentNodes.Add(childrenNodes[j]);
                    }          
                    
                }
               // parentNodes = childrenNodes;

                //clearing the childrenNodes to make way from the children of the new parents
                childrenNodes.Clear();

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
                //}
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
                Traverse(node.Left);
                Console.WriteLine(node.Data);
                Traverse(node.Right);
                
            }
        }


    }
}
