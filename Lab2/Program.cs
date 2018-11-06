using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Multiplication
    {
        // Main method begins execution of C# application
        public static void Main ( string[] args)
        { 
            int number1; //declares first number to add
            int number2; //declares second number to add
            int sum; // declare sum of number1 and number2
        
            Console.Write("Enter first integer: "); //prompt user
            //read first number from user
            number1 = Convert.ToInt32 (Console.ReadLine() );
            
            Console.Write( "Enter second integer: " ); //prompt user
            // read second number from user
            number2 = Convert.ToInt32 ( Console.ReadLine() );

            sum = number1* number2; // multiply numbers

            Console.WriteLine( "Sum is {0}", sum); // display sum
            
            Console.WriteLine("{0}\n{1}", "Hello World!", "From David Gordon"); //Executes Hello World! From David Gordon on multiple lines
            
            Console.WriteLine("{0}\t{1}", "Hello World!", "From David Gordon"); //Executes Hello World!     From David Gordon
}
    }
}

// Answer A: Our program executes at the Main method (see above: public static void Main (string[] args).

/* Answer B: Integers and floats are two types of numerical data representations with varying degrees of precision. 
Integers are numbers without decmials, where floats are numbers that contain decimals and can represent smaller units, compared to intergers. */

// Answer C: Method example: myAccount.SetName(theName); // put theName in the myAccount object

// Answer D: "Get" Accessor, followed by "Set" Accessor.

/* Answer E: Class could be described as the mental construct or blueprint of an application, where Objects are the mechanical components that come together to perform a method for function in the class. 
   C# is an extensible programming language that can have thousands of classes which form a more complex application. Each class could be considered a different concept with the own functioning components that come together.
*/
 