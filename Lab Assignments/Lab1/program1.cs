/*
Q. WAP to implement multiple inheritance using Interface in C#.
*/

using System;

namespace MultipleInheritanceInterface
{
    interface IWalk { void Walk(); }
    interface ISwim { void Swim(); }
    public class Animal
    {
	string name;
	public Animal(string name) 
	{
	    this.name = name;
	}
	public void Name()
	{
	    Console.WriteLine($"I am {this.name}.");
	}
    }
    public class Penguin : Animal, IWalk, ISwim
    {
	public Penguin(string name) : base(name) {}

	public void Walk()
	{
	    Console.WriteLine("I can Walk.");
	}
	public void Swim()
	{
	    Console.WriteLine("I can Swim.");
	}
    }
    class Program
    {
	public static void Main(string[] args)
	{
	    Penguin penguin = new Penguin("Penguin");
	    penguin.Name();
	    penguin.Walk();
	    penguin.Swim();
	}
    }
}
