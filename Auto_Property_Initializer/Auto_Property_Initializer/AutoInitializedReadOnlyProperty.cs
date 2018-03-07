using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Property_Initializer
{
    public class AutoInitializedReadOnlyProperty
    {
        public string FirstName { get; } = "Johnny";
        public string LastName { get; } = "Depp";
    }
}
