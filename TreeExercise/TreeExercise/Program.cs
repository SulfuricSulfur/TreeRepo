using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
            string output;
           // string output = Console.ReadLine();
            int numLvl;//parsing the string to a number
            do//ask for input once. If it is invalid, keep asking.
            {
                Console.WriteLine("How many levels of the tree would you like? ");
                output = Console.ReadLine();
                if (int.TryParse(output, out numLvl) == false || numLvl <0 )//added an exception if user enters a negative number or a character
                {
                    Console.WriteLine("That is not a valid number. Please try again.");
                }

            }
            while (int.TryParse(output, out numLvl) == false);//while the user has entered an invalid input, keep asking)


            Console.WriteLine("Processing the tree");//telling the user that the tree is being created
            try
            {

                binaryTree.Insert(numLvl);//enter the user's input and print out tree
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Ran out of memory. Try a smaller number of levels. Displaying numbers before exception.");
            }
            binaryTree.Traverse(binaryTree.Root);

            //this will leave the console window open until the user presses a key to exit
            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
