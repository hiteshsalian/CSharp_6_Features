using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{
    public class NullObjectCheck : IUsage
    {
        public void ShowUsage()
        {
            Subject biology = null;
            Subject maths = new Subject { Name = "Mathematics", TuitionFee = 400 };
            Subject physics = new Subject { Id =2, Name = "Physics", TuitionFee=500};
            Subject chemistry = new Subject { Id = 1, Name = "Chemistry", TuitionFee = 400};

            Console.WriteLine($"Biology Id {biology?.Id ?? null}");

            // usage of string interpolation - another feature in C# 6.0
            Console.WriteLine($"The {maths.Name} subject whose Id is { (maths.Id.HasValue? maths.Id.Value : (int?) null) } costs ${maths.TuitionFee}.");
            Console.WriteLine($"The {physics.Name} subject whose Id is {physics.Id} costs ${physics.TuitionFee}.");
            Console.WriteLine($"The {chemistry.Name} subject whose Id is {chemistry.Id} costs ${chemistry.TuitionFee}.");
        }
    }

    public class Subject
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public double TuitionFee { get; set; }
    }
}
