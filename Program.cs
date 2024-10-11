// See https://aka.ms/new-console-template for more information
using ConsoleGenerics;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

Generics<int> intStack = new Generics<int>();

// Push items onto the stack
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);

// Display the count of items in the stack
Console.WriteLine("Count: " + intStack.Count());

// Pop items from the stack
Console.WriteLine("Popped: " + intStack.Pop());
Console.WriteLine("Popped: " + intStack.Pop());

// Display the count after popping
Console.WriteLine("Count after popping: " + intStack.Count());