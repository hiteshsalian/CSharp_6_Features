using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{
    public class NullTextCheck : IUsage
    {
        public void ShowUsage()
        {
            string text = null;
            string anotherText = "Hello World";

            Console.WriteLine($"The length of the text variable is { text?.Length ?? 0}");
            Console.WriteLine($"The length of the anotherText variable is { anotherText?.Length ?? 0}");
        }
    }
}
