﻿using System;
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
        private Node root;//the start of the tree
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
                int numTraverse = 0 ;
                Console.WriteLine(node.Data);

                Traverse(node.Left, numTraverse);
                
                Traverse(node.Right, numTraverse);
                
            }
        }

        /// <summary>
        /// keeps goign all the way to the left printing out the numbers.
        /// if there is no more to the left, it goes up one and then to the right. then up one more, to the right, then to left etc. etc.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="numTraverse"></param>
        private void Traverse(Node node, int numTraverse)
        {
            if (node != null)
            {
                numTraverse++;//takes in how many times it has been tranersed and adds that to a counter. This determines how many ">" there will be
                for(int i =0; i < numTraverse; i++)
                {
                    Console.Write(">");
                }
                Console.WriteLine(node.Data);
                Traverse(node.Left,numTraverse);

                Traverse(node.Right, numTraverse);

            }
        }
    }
}
