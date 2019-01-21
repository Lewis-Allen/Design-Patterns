# Visitor Pattern

Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates (Gang of Four).

In this example, we implement a binary tree of integers with the following structure:

![](BinaryTree.png)

Using the visitor object `SumVistor`, we transverse the binary tree and add up all of its values.

## UML Diagram of the example.
![](VisitorPattern.png)