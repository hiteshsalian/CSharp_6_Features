using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Property_Initializer
{
    public class HistoricalProperty
    {
        private string firstName; // This was a backing field or underlying field
        private string lastName; // This was a backing field or underlying field

        public HistoricalProperty()
        {
            firstName = "Rahul";
            lastName = "Dravid";
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                }
            }
        }
    }
}
