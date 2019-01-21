# Template Method Pattern

The Template Method Pattern allows you to define the skeleton of an algorithm in an operation, deferring some steps to the subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithms structure. (Gang of Four).

In this example, we define the abstract class `Sandwich` which details steps into making a sandwich in the method `Make`. Each step of the sandwich making process such as `AddSpread` or `AddMeat` can be redefined or ignored by the subclasses, allowing steps to be modified without changing the structure of the making process. `BaconSandwich` ignores the `AddCheese` step. `CheeseSandwich` ignores the `AddMeat` step.

The delicious sandwich can then be eaten using `sandwich.Eat();`

## UML Diagram of the example.
![](TemplateMethodPattern.png)
