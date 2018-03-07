using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{

    /// <summary>
    /// This program shows the usage of Safe Navigation Operator or Null Conditional Operator.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            new NullCollectionCheck().ShowUsage();

            var nullEventCheckObj = new NullEventCheck();
            nullEventCheckObj.PropertyChanged += Program_PropertyChanged;
            nullEventCheckObj.ShowUsage();

            new NullObjectCheck().ShowUsage();

            new NullTextCheck().ShowUsage(); 
            Console.ReadLine();
        }

        private static void Program_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName);
        }
    }
}
