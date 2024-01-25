using System.Security.Cryptography.X509Certificates;
/// <summary>
/// Sam Ford
/// 1/24/24 (would you look at that)
/// DGM 1400
/// 
/// work was done in visual studio code.
/// This was a review for me because the first programing language I learned was C#
/// Refreshing on synax was good. 
/// Varables and operators are pretty much the same as python but more annoying.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        ///basic declaration. extra note, python is way nicer :(
        string shout = "hello every nyan";
        int numba = 4;
        bool boring = true;
        float pi = 3.141596f;
        double pi2 = 3.141596535897;

        ///"fun" with printing and operators, also if and for
        ///Arithmetic:
        ///+ adds, - subtracts, * multiplies, / divides, % modulus, ++ increment, -- decrement
        ///will print "hello every nyan
        Console.WriteLine(shout);

        ///will print 4, 4 times
        for (int i = 0; i < numba; i++)
        {
               Console.WriteLine(numba);
        }

        /// checks a bool and prints a string based off of it
        if (boring == true){
            Console.WriteLine("print this if this review is boring but necessary");
        }

        ///adding strings together with floats and bools. Prints pi to 6 decimals and pi to 12 decimals.
        Console.WriteLine("short pi is "+ pi + " slightly longer pi is " + pi2);

        ///there are so many assignemnt variables im not listing them.
        ///Most are used if you want to do something to the variable with itself.
        ///ex. 
        int exampleInteger = 3;
        exampleInteger = exampleInteger + 3;
        /// shorter version with assignemnt variable
        exampleInteger += 3;
        ///they print the same
        
        ///Comparison and logical operators are useful for, well, logic
        ///&& and, || or, ! not.
        ///== equals, < less than, > greater than, != not equals.
        ///these are good for using with bools and if statements

        ///I don't feel the need to give examples for all of these, I already know them.
        ///the refreser to synax in C# was good but it would be a waste of time to do comparison and variable manipulation.
    }
}