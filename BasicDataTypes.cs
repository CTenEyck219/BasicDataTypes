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

            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());

            Console.WriteLine("12.Equals(32) = {0}", 12.Equals(32));

            Console.WriteLine("12.ToString() = {0}", 12.ToString());

            Console.WriteLine("12.GetType() = {0}", 12.GetType());

            Console.WriteLine("12.GetTypeCode() = {0}", 12.GetTypeCode());
        }
    }
}
