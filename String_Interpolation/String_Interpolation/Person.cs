using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    public class Performer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Profession { get; set; }
        public int ShowPrice { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
