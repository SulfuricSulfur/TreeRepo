The script is composed of a tree class, a node class, and a base program class. The node class is what holds the data for tree. 
There is a right, left, and data attribute in the class. The data int is what holds the actual number for the node. The left node
is a reference to the child node that will be on the left of the current node. The right node reference is a reference to the child
node that will be to the right of the current node. The node class itself requires an int to be passed in and sets that int as
the data for the node. For starting off, the right and left children node are set as null. There are properties in the node class
in order to allow the program to access and set reference to the right, left, and data attributes. The tree class is where the actual
tree creation will take place. The tree class has a root node(has a data value set to 1 by default and will never change), a list of 
children nodes, and a list of parent nodes. In the tree class there are two methods, the Insert method and the Traverse method.
The Insert method is where the children nodes are established and set from the parent nodes a long with setting the data value based 
on the parent's position and neighbors. The method itself is public and takes in the number of levels that the user inputted. 
There is a for loop that will loop through the Insert method based on the input. There are special cases for the root, and the
children of the root node. The case will set up the root node in the parent list and also make the children nodes left and right of
the root parent node. The root node is the first level. For all other cases, there is a nested for loop that will loop through the parent node list and create the
children nodes. The creation of the children are based on the parent's position in the list. If the parent is the first or last
in the list, it will set one of the children(right or left depending on if the first or last in the list) and set the data equal
to the parent's and then calculate the other child based on the neighbor that is next to the parent.  For the parent's that are in the
middle of the list, the children nodes will be set based on the parent's data, and the neighbor left and right of the parent.
After the children have been established, they will be added to the children node list. Because of the order of the parents are in the loop,
the position of the children in the list will be the same as the parent, starting with the left child of the first in the list
and then the right. The parent list will then be cleared and be replaced by the children list, thus the children becoming the new parents.
The old children list will then be cleared. This will happen until there are no more levels left. This sets it up so now each node has 
reference to the children to the left and right of the parent node.

The next method is the Traverse method. There are two of these methods from overloading. The first one takes in just a node and is public. The node
will always be the root. If the root is not null, the left and right node of the root node will be sent to the private method as well as the
number of times the method has been traversed. From that method, as long as the node is not null, the method will be called recursively.
Starting from the current node, the method will print out the data of the node, then go to the left. Depending on what level the node is on,
there will be a number of > next to the number. If a node is on the fourth level, there will be 3 > (the root does not have one). The method will
traverse through the left and print out until there is no more on the left, from there it will print out the right. It will then go back up
and then to the right, from there it will decent left until there is none left and then  print out the right. This will continue until there is no
more nodes left.

In the program method, a tree object will be instantiated so that its methods can be accessed. There is also an int for the number the user wants and the output string to convert.
The console window will prompt user for an input. The program will check to see if it is valid(either character or a negative number is invalid). The window
will keep asking user for a valid input until they finally enter a number that meets the loop's conditions. From there, the number will be sent to the tree's
Insert method to be processed. Some large numbers cause an OutOfMemory Exception due to the recursion and for loops. On debug, the console will give the user
the numbers it was able to process up until that point. When the tree is printed out and finished, it will then tell the user to press any key to finish.
Pressing any key will close the console window.

Because of the program, the console has already been compiled as an executable. The executable is located in the debug folder which is in the bin folder of the project.
Double clicking the application should open the console window and run it. The program then should run as expected and will close the window if the user presses a key
at the end or it the program encounters an error. 

The code is organised into three main classes that handle the work. The tree class is where most of the work involving generating and setting the tree takes place.
The node class is where the data is stored. The program class is where the program is started and initialized. The modules used are the base modules that are given
in Visual Studio C# programs. The modules have been created from the classes, which access eachother from inside the code. 

Once the program is started, user will be prompted for an int. Once a valid int is entered, the int will be passed to the tree class via Insert method. 
From there, inside the tree class, the tree itself will be generated. When a node is created, control will be passed to the node class, where the node itself 
will be set up. After the tree has been created, the control will be passed back to the program class. From there, control will be passed to the public Traverse method. 
The public Traverse method will then give control to the private Traverse method that will handle printing out the node’s data from there. The Traverse private method
 handles printing out recursively. After all the data from the nodes have been printed out, the control will exit the method and the tree class and return to the main program class. 
From there the control will remain and keep the program open until user presses key to exit program. See above for more in-depth about each part of the program.