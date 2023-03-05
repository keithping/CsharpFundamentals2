using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The universal term for an object in C# is a POGO.
            //POGO stands for Plain Old CLR(Common Language Runtime) Object
            //How a computer understands what we are writing is through a runtime.
            //C# uses Common Language Runtime to compile your code and then turn it into machine readable code.
            //There are four pillars of Object Oriented Programming
            //1. Encapsulation.  The most important part of Encapsulation is privacy.
            //-This is in reference to: What other files, classes, projects, etc., have access to the properties, methods, etc., inside my object. These are known as access modifiers.
            //2. Abstraction.  This allow you to create reusable, simple to understand, easily changable code bases by abstracting away certain details.
            //3. Inheritance.  This helps you eliminate redundant code.
            //4. Polymorphism.  This eliminates the use of unnessary code in conditions.  This allows things to share behaviors, or chose to not share behaviors (called overwriting).  You can also add other behaviors to the the child classes that the parent classes might not have.

            //The following lines of code were taken from ReferenceTypes.cs to be tested here because ReadLine doesn't work in a Unit Test Project.
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName);
            Console.ReadLine();
        }
    }
}
