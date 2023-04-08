using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWindowsFormsApp
{
    // The Customer class is defined as internal, meaning that it can only be accessed within the same assembly.
    internal class Customer
    {
        private string name;

        // The constructor for the Customer class takes a single parameter, which is the customer's name.
        public Customer(string name)
        {
            this.name = name;
        }

        // The Name property of the Customer class allows the name of the customer to be retrieved or set.
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
