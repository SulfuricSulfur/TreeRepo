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
            Console.WriteLine("How many levels of the tree would you like? ");
            string output;
           // string output = Console.ReadLine();
            int numLvl;//parsing the string to a number
            do//ask for input once. If it is invalid, keep asking.
            {
                Console.WriteLine("How many levels of the tree would you like? ");
                output = Console.ReadLine();
                if (int.TryParse(output, out numLvl) == false)
                {
                    Console.WriteLine("That is not a valid number. Please try again.");
                }

            }
            while (int.TryParse(output, out numLvl) == false);//while the user has entered an invalid input, keep asking)

                binaryTree.Insert(4);
            binaryTree.Traverse(binaryTree.Root);
        }
    }
}
