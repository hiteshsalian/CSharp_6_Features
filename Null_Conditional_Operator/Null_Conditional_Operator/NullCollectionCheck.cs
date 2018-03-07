using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{
    public class NullCollectionCheck : IUsage
    {
        public void ShowUsage()
        {
            List<string> names = null;

            // using the null conditional operator and invoking the collection member
            Console.WriteLine(names?.Count ?? 0);

            // using the null conditional operator with index [
            Console.WriteLine(names?[1]);


            List<string> cities = new List<string> { "Chennai", "Bangalore", "Hyderabad", "Delhi", "Mumbai", "Ahmedabad"};
            // using the null conditional operator with index [
            string city = cities?[1];
            Console.WriteLine(city);

        }
    }
}
