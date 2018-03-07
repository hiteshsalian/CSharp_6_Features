using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Property_Initializer
{
    /// <summary>
    /// This program is an example for Auto Property Initializer as introduced in C# 6.0
    /// ref : https://csharp.today/c-6-features-auto-property-initializers/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HistoricalProperty oldProperty = new HistoricalProperty();
            Console.WriteLine($"Historically Property values FirstName : {oldProperty.FirstName} and LastName : {oldProperty.LastName}");

            AutoImplementedProperty autoImpProperty = new AutoImplementedProperty();
            Console.WriteLine($"Auto Implement Property introduced in C# 3.0 values FirstName : {autoImpProperty.FirstName} and LastName : {autoImpProperty.LastName}");

            AutoPropertyInitialized autoPropInitialized = new AutoPropertyInitialized();
            Console.WriteLine($"Auto Property Initialized introduced in C# 6.0 values FirstName : {autoPropInitialized.FirstName} and LastName : {autoPropInitialized.LastName}");

            AutoInitializedReadOnlyProperty autoInitializedReadOnlyProp = new AutoInitializedReadOnlyProperty();
            Console.WriteLine($"Auto Initialized Read Only Property introduced in C# 6.0 values FirstName : {autoInitializedReadOnlyProp.FirstName} and LastName : {autoInitializedReadOnlyProp.LastName}");


            Console.ReadLine();
        }
    }
}
