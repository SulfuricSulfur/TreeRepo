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

            Console.WriteLine("Okay, before I show you the tree do you want to play a guessing game? ");
            string userReply = Console.ReadLine();
            if(userReply.ToUpper() == "YES" || userReply.ToUpper() == "SURE" || userReply.ToUpper() == "OKAY" || userReply.ToUpper() == "Y")
            {
                int numGuess = 8;//the number of guesses the user has left
                Console.WriteLine("Okay cool" );//prompting user to enter a guess for the number of nodes
                int answer;//the answer the user submitted
                string guess;
                do
                {
                    Console.WriteLine("From the number of levels you entered, guess how many numbers there will be total," + "\nYou have " + numGuess + " tries left: ");
                    guess = Console.ReadLine();
                    if (int.TryParse(guess, out answer) == false)
                    {
                        Console.WriteLine("That is not a valid number. Please try again.");
                    }
                    //else if(guess)
                } while (numGuess > 0);
                

            }
            

                binaryTree.Insert(numLvl);
            binaryTree.Traverse(binaryTree.Root);
        }
    }
}
