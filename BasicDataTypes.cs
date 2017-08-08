using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BigInteger Lives here!
using System.Numerics;

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

            ParseFromStrings();

            UseDatesAndTimes();

            UseBigInteger();

            StringFunctionality();

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

            /*A C# int is really a shorthand for System.Int32,
            *Which inherits the following members from System.Object.*/

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

        static void ParseFromStrings()
        {

            Console.WriteLine("=> Data type parsing:");
            /*Exploring different methods of parsing string data
             * into something that is usable as a different type */


            //Parsing string "True" to boolean
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            //Parsing string "99.884" to double
            double d = double.Parse("99.884");
            Console.WriteLine("Value of d: {0}", d);

            //Parsing string "8" to int
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);

            //Parsing string "w" to char
            char c = Char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);

            //Spacer
            Console.WriteLine();

        }

        static void UseDatesAndTimes()
        {

            Console.WriteLine("=> Dates and Times:");
            //Exploring the DateTime and TimeSpan structures

            //This constructor takes (year, month, day)
            DateTime dt = new DateTime(2017, 8, 7);

            //What day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            //Month is now December
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings?: {0}", dt.IsDaylightSavingTime());

            //This constructor takes (hours, minuets, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            /*Subtract 15 mins from current TimeSpan and
             * Print the results */
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

            //Spacer
            Console.WriteLine();

        }

        static void UseBigInteger()
        {

            Console.WriteLine("=> Use BitInteger:");
            //Defining, calling, and multiplying BigInteger

            //Defining BigInteger
            BigInteger bigin =
                BigInteger.Parse("9999999999999999999999999999999999999999999999999999"
                + "99999999999999999999999999999999999999999");
            Console.WriteLine("The value of bigin is: {0}", bigin);

            //Checking even
            Console.WriteLine("Is bigin an even value?: {0}", bigin.IsEven);

            //Checking if bigin is power of 2
            Console.WriteLine("Is bigin a power of two?: {0}", bigin.IsPowerOfTwo);

            //Multiplying bigin with lilBrother
            BigInteger kindaBig = BigInteger.Multiply(bigin,
                BigInteger.Parse("7777777777777777777777777777777777777777777777"));

            //Lets see Kinda Big
            Console.WriteLine("The kinda big value is : {0}", kindaBig);
            
            //Defining another BigInteger to mutiply with bigin
            BigInteger bigBrother = BigInteger.Parse("8888888888888888888888888888888888"
                + "8888888888888888888888888888888888888888888888888888888888888888888888");

            //Lets multiply these bad boys
            BigInteger sumoBig = bigin * bigBrother;

            //Now the finally
            Console.WriteLine("The value of sumoBig is: {0}", sumoBig);

            //Spacer
            Console.WriteLine();

        }

        static void StringFunctionality()
        {

            Console.WriteLine("=> String functionality:");
            /*Looking at some different functionality of strings
             * and ways that strings can be manipulated */

            //Setting initial string
            string firstName = "Freddy";

            //Print first name
            Console.WriteLine("Value of first name is: {0}", firstName);

            //Printing num of char's in first name
            Console.WriteLine("First name has {0} characters", firstName.Length);

            //Making first name uppercase
            Console.WriteLine("First name in uppercase: {0}", firstName.ToUpper());

            //Making first name lowercase
            Console.WriteLine("First name in lowercase: {0}", firstName.ToLower());

            //Comparing first name with another string
            Console.WriteLine("First name compared with 'Johnny': {0}",
                firstName.CompareTo("Johnny"));

            //Does first name contain this?
            Console.WriteLine("Does first name contain 'ddy'?: {0}", 
                firstName.Contains("ddy"));

            //Does first name contain this?
            Console.WriteLine("Does first name contain 'nny'?: {0}",
                firstName.Contains("nny"));

            //Does first name equal this other name?
            Console.WriteLine("Is first name equal to 'Jenny'?: {0}", 
                firstName.Equals("Jenny"));

            //Lets give first name a Prefix
            Console.WriteLine("Here is first name's prefix: {0}",
                firstName.Insert(0, "Mr. "));

            //Let us add some padding to the left and right
            Console.WriteLine("First name needs some space: {0}",
                firstName.PadLeft(6).PadRight(6));

            //We are going to remove some letters
            Console.WriteLine("Formal fist name: {0}",
                firstName.Remove(4));

            //We could also just replace some letters
            Console.WriteLine("Formal first name again: {0}",
                firstName.Replace("dy", ""));

            //Spacer
            Console.WriteLine();
        }
    }
}
