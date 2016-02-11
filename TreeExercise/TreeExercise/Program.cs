using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //the tree object itself
            Tree binaryTree = new Tree();

            //Will ask user for input later on. For now putting in levels for debugging

            //Asking user for how many levels they want
            //Console.WriteLine("How many levels of the tree would you like? ");
            //int numLvl = int.Parse(Console.ReadLine());//parsing the string to a number

            binaryTree.Insert(4);
            binaryTree.Traverse(binaryTree.Root);
        }
    }
}
