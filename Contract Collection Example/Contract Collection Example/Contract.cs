using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Collection_Example
{
    //here contract is just used like a struct, but in this case it is still a class;
    //this class here serves a way of having a block of data to send in as a contract
    //object
    public class Contract
    {
        public string number;
        public string name;
        public double amount;
        public DateTime startDate;
    }
}
