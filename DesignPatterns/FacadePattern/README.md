# The Facade Pattern

The Facade pattern provides a high-level unified interface that makes a subsystem easier to use. A facade object is a simplified way of accessing the functionality of a subsystem.

In our example we implement a facade class that can be called to provide the functionality of depositing and withdrawing, without the implementer having to concern themselves with the underlying system.

The Facade can be applied in many different scenarios such as:

- The Facade pattern allows you to provide a simplistic interface to a complex subsystem. The facade provides an easy to use view of the underlying system without removing the option to customise it if required.
- The pattern can reduce dependencies between clients and the underlying systems through decoupling.
- You can layer your subsystem by providing a facade as an entry point for each layer. This can reduce the dependency between layers by having them communicate only through their facades.