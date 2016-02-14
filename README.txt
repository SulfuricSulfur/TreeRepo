The script is composed of a tree class, a node class, and a base program class. The node class is what holds the data for tree. 
There is a right, left, and data attribute in the class. The data int is what holds the actual number for the node. The left node
is a refrence to the child node that will be on the left of the current node. The right node refrence is a refrence to the child
node that will be to the right of the current node. The node class itself requires an int to be passed in and sets that int as
the data for the node. For starting off, the right and left children node are set as null. There are properties in the node class
in order to allow the program to access and set frefrence to the right,left, and data attributes. The tree class is where the actual
tree creation will take place. The tree class has a root node(has a data value set to 1 by default and will never change), a list of 
children nodes, and a list of parent nodes. In the tree class there are two methods, the Insert method and the  Traverse method.
The Insert method is where the children nodes are established and set from the parent nodes a long with setting the data value based 
on the parent's position and neighbors.