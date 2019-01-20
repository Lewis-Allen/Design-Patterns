# Adapter Pattern

The *Adapter Pattern* converts the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible itnerfaces (Gang of Four).

In our example, we have the IDog interface and the IToydog interface. One with a Bark method the other with a FakeBark method. We want to turn our Labrador instance into an IToyDog instance and allow it to do FakeBark like the PlasticDog does.

## UML Diagram of the example.
![](AdapterPattern.png)
