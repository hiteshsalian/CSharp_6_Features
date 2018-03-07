using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Property_Initializer
{
    // Auto Implemented Properties were introduced in C# 3.0
    public class AutoImplementedProperty
    {
        public AutoImplementedProperty()
        {
            FirstName = "Bill";
            LastName = "Gates";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
