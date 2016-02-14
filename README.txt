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
After the children have been established, they will be added to the children node list. Because of the order of how they parent's are
looped through, the postion of the children in the list will be the same as the parent, starting with the left child of the first in the list
and then the right. The parent list will then be cleared and be replaced by the children list, thus the children becoming the new parents.
The old children list will then be cleared. This will happen until there are no more levels left. This sets it up so now each node has 
reference to the children to the left and right of the parent node.

The next method is the

