using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    public enum PastryType
    {
        Cake = 0,
        Danish,
        Croissant,
        Donut,
        Scone,
        Backlava
    }
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            // A variable is a named location in computer memory (RAM).
            // Sometimes a compute will store a variable directly in its local memory so you can pull from it quickly and easily.  These are known as Value Type variables.
            // Reference Type variables don't necessarily get immediately stored in local memory.  Rather than being stored in local memory, an address that points to the variable in another allocation of memory would be a Reference Type variable.
            // Value Type variable are stored in the stack.  Reference Type variables are stored in the heap.

            int numOne; // Here a variable is declared.
            numOne = 1; // Here a variable is initialized.
            int numTwo = 2; // Here a variable is declared and initialized.
        }

        [TestMethod]
        public void ValueVariableTypes()
        {
            // Whole numbers 
            byte byteExample = 255;  //0-255
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            int intMax = 2147483647;
            Int32 anotherIntExample = 123456;
            long longMax = 9223372036854775807;
            Int64 longMin = -922337203685775807;

            // Decimals
            double doubleExample = 1.23456789;  // A double will hold less memory than a decimal.
            float floatExample = 1.2346558f;
            decimal decimalExample = 1.43567868099m;

            Console.WriteLine(doubleExample);

            // Characters
            char charExample = 'a';
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n';  // This is an example of an escape character.  This specific escape character is also an example of a carriage return, which provides a way to get to a new line.

            // Bools
            bool isHungry = true;
            bool isTired = false;

            // Enums
            PastryType myPastry = PastryType.Backlava;

            // Structs
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

        }
    }
}
