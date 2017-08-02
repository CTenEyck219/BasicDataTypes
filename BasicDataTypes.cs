using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class BasicDataTypes
    {
        static void Main(string[] args)
        {

            LocalVarDeclarations();

            NewingDataTypes();

            ObjectFunctionality();

            DataTypeFunctionality();

            CharFunctionality();

            Console.ReadLine();

        }

        static void LocalVarDeclarations()
        {

            Console.WriteLine("=> Data Declarations");

            //Local Variable are declared as so:
            // dataType varName;
            int myInt = 0;          //Inline Declaration

            //Multiple line assignment
            string myString;
            myString = null;

            //Multiple Inline Declarations
            bool b1 = true, b2 = false, b3 = b1;

            //Using System.Boolean data type fo declare a boolean type
            System.Boolean b4 = false;

            //Echo Data
            Console.WriteLine("Declared data: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1, b2, b3, b4);

            //Spacer
            Console.WriteLine();

        }

        static void NewingDataTypes()
        {

            Console.WriteLine("=> Using 'new' to create variables:");
            bool b = new bool();                 //Set to false
            int i = new int();                   //Set to 0
            double d = new double();             //Set to 0
            DateTime dt = new DateTime();        //Set to 1/1/0001 12:00:00 AM

            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);

            //Spacer
            Console.WriteLine();

        }

        static void ObjectFunctionality()
        {

            Console.WriteLine("=> System.Object Functionality:");

            //A C# int is really a shorthand for System.Int32,
            //Which inherits the following members from System.Object.

            //Shows the HashCode for 12
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            //Checks equality and returns a boolean value
            Console.WriteLine("12.Equals(32) = {0}", 12.Equals(32));
            //Converts to a string
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            //Shows what type
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            //Returns the type code
            Console.WriteLine("12.GetTypeCode() = {0}", 12.GetTypeCode());

            //Spacer
            Console.WriteLine();

        }

        static void DataTypeFunctionality()
        {

            Console.WriteLine("=> Data type Functionality:");
            //Illustration of data type values such as min, max, epsilon, and infinity

            //Shows the max value int can be
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            //Shows the min value int can be
            Console.WriteLine("Min of int: {0}", int.MinValue);
            //Shows the max value double can be
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            //Shows the min value double can be
            Console.WriteLine("Min of double: {0}", double.MinValue);
            //Returns the value for Epsilon
            Console.WriteLine("double.epsilon: {0}", double.Epsilon);
            //Returns positive infinity
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            //Returns negitive infinity
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);

            //Spacer
            Console.WriteLine();

            //Additional data type functionality with boolean

            //Returns false
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            //Returns true
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

            //Spacer
            Console.WriteLine();

        }

        static void CharFunctionality()
        {

            Console.WriteLine("=> Char type Functionality:");

            //Exploring and illustrating the functionality of char

            //Setting value for myChar
            char myChar = 'a';

            //Checking if char is a digit
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            //Checking if char is a letter
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            //Checking to see if char is white space at a specific point (true)
            Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", 
                char.IsWhiteSpace("Hello There", 5));
            //Checking to see if char is white space at a specific point(false)
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
                char.IsWhiteSpace("Hello There", 6));
            //Checking to see if char is a form of punctuation
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));

            //Spacer
            Console.WriteLine();

        }

    }
}
