using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    /// <summary>
    /// This Program shows the implementation of String interpolation in C# 6.0
    /// Reference
    /// https://csharp.today/c-6-features-string-interpolation/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            // before C# 6.0 string were formatted using 
            // We used to use string.Format method to construct strings. 
            // This method is very helpful however we need to take care of placeholders in the format string that must be matched with obect arguments in same order

            Performer a = new Performer { FirstName = "Salman", LastName = "Khan", Age = 50, Gender = Gender.Male, Profession = "Actor", ShowPrice = 300 };
            Performer b = new Performer { FirstName = "Katy", LastName = "Perry", Age = 33, Gender = Gender.Female, Profession = "Singer", ShowPrice = 200 };
            Console.WriteLine("Using String Format");
            Console.WriteLine(string.Format(@"{0} {1} is {2} years old. {3} is a {4}.", a.FirstName, a.LastName, a.Age, a.Gender == Gender.Male ? "He" : "She", a.Profession));
            Console.WriteLine(string.Format(@"{0} {1} is {2} years old. {3} is a {4}.", b.FirstName, b.LastName, b.Age, b.Gender == Gender.Male ? "He" : "She", b.Profession));

            Console.WriteLine(); 
            //String interpolation introduces a new way of getting the same string in much easier to read form. You can just put expressions directly in string literal.
            //interpolated string starts with $
            //Additionally, we can add formatting as in string.Format
            //  interpolated strings are transformed at compile time to equivalent string.Format calls.
            Console.WriteLine("Using String Interpolation");
            Console.WriteLine($"{a.FirstName} {a.LastName} is {a.Age} years old. {(a.Gender == Gender.Male ? "He" : "She")} is a {a.Profession}. Show Ticket Price is {a.ShowPrice:C}");
            Console.WriteLine($"{b.FirstName} {b.LastName} is {b.Age} years old. {(b.Gender == Gender.Male ? "He" : "She")} is a {b.Profession}. Show Ticket Price is {b.ShowPrice:C}");

            Console.ReadLine(); 
        }
    }
}
