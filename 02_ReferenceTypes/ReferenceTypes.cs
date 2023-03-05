using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_ReferenceTypes
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void ReferenceTypeVariables()
        {
            //Strings
            string thisIsDeclaration;
            thisIsDeclaration = "This is initialized.";

            string declarationAndInitialation = "This is both declaring and initializing a string.";

            //'Ctrl+k+c' will comment out an entire block of code
            //Console.WriteLine("What is your name?");
            //string firstName = Console.ReadLine(); 
            //Console.WriteLine(firstName);

            //String Operation:
            //Concatenation and interpolation are two way of mashing strings together.  
            //Concatenation:
            string concatenatedFullName;
            string firstName = "Severa";
            string lastName = "Cox";
            concatenatedFullName = firstName + " " + lastName; //Severa Cox (Here a space needs to be placed between the quotation marks of the firstName and lastName.  If not, it will display SeveraCox.
            Console.WriteLine(concatenatedFullName);

            //Interpolation:
            string interpolatedFullName = $"{firstName} {lastName}";//Severa Cox (Here, a space needs to exist between {firstName} and {lastName}.  If not, it will display SeveraCox.
            Console.WriteLine(interpolatedFullName);

            //Collections:
            //A collection is a variable that contains many other variables.
            //Lists:
            //If you place the cursor inside of the word List and then hit 'ctrl+.', intellisense will pop up with a list of suggestions.  In this case, we want 'using System.Collection.Generic'.  This will import other files that exist in the background in the metadata.  This is one of the many pros of using a framework.  C# uses .net framework.
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add(firstName);
            listOfStrings.Add(lastName);

            //Array:
            //When an array of any type is declared, we must state how many items will be in that array.  As a result, arrays are not used very often in C#.  This is because we will rarely want a collection where you have to automatically declare in advance how many items we'll want to have in it.
            string[] arrayOfStrings = new string[8];
            string[] anotherArrayOfStrings = { firstName, lastName, "blah blah blah" };

            //Queue:
            //Queues always follow the rule of 'first in, first out'.
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue(lastName);//Enqueue add an object to the end of a queue.
            firstInFirstOut.Enqueue("This is my string added to my queue.");

            //Dictionary:
            //A dictionary collection comes if the form of a key/value pair.  In the following example, the key is in the form of an 'int', and the value is in the form of a 'string'.
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(7, "seven");
            Console.WriteLine(keyValuePairs[7]);

            //Other Types Collections:
            //SortedList:
            //A sorted list also represents a collection key/value pairs, but they are sorted by the key based on association.
            SortedList<string, int> sortedKeyValuePairs = new SortedList<string, int>();
            //HashSet;
            //A HashSet is a collection that cannot have duplicates.  For example, if you attempted to use the same integer twice in a HashSet collection, it would not be allowed.
            HashSet<int> uniqueList = new HashSet<int>();
            //Stack:
            //A stack is the exact opposite of a queue, so it follows the rule of 'last in, first out'.
            Stack<string> lastInFirstOut = new Stack<string>();

            //Classes
            Random randomExample = new Random();

            int randomNumber = randomExample.Next();
            Console.WriteLine(randomNumber);

        }
    }
}
