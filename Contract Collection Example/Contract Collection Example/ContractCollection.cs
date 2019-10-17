using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Collection_Example
{
    class ContractCollection
    {
        //Instantiated dictionary for a contract list. 
        
        /*
         *  A dictionary is a collection that is defined with a key value pair type. It
         *  is typically used to have an identifier and a value to easily reference information
         *  or objects that are to be stored.
         *  
         *  in this case we have a key value string that is related to a contract and this
         *  dictionary holdsa list of contracts that can be referenced by said related string.
         */
        Dictionary<string, Contract> contractList = new Dictionary<string, Contract>();


        //Here this defined dictionary property with an explicit class reference of a value collection
        //
        //This value collection has multiple interfaces that allows it for enumerate, as well
        //as a properties and methods to help in the value colleciton
        public Dictionary<string, Contract>.ValueCollection AllContracts //can loop thru contracts
        {
            get { return contractList.Values; }
        }

        //This is an add contract method that adds the contract has been instantiated.
        //
        //The key-value pair in this case is the contract.number(key), and the contract object(value)
        public void AddContract(Contract contract)//Add
        {
            //This method implements the .add method of the dictionary Contract list
            contractList.Add(contract.number, contract);
        }

        //removes the contract from the contract list using the method remove
        //which points to the index (or key) of the dictionary item
        public void RemoveContract(string number)//Delete
        {
            contractList.Remove(number);
        }

        //finds the contract by the key value in the dictionary
        public Contract FindContract(string number)
        {

            Contract find;
            if (contractList.ContainsKey(number))
            {
                find = contractList[number];
                return find;
            }
            else
            {
                return null;
            }//end if

        }//end find

        //retrieves the total amount from all contracts
        public double TotalAmount()
        {
            double total = 0;
            foreach (Contract item in AllContracts)
            {
                total += item.amount;
            }
            return total;
        }//end total

        //this method is used for the secondary form and presents all the contracts
        //as well as the total sum of the sales;
        public override string ToString()
        {
            string str = "Number\t" + "Name\t" + "Amount\t\t" + "Date \r\n";
            double total = 0;
            foreach (Contract contract in AllContracts)
            {
                str += $"{contract.number}\t{contract.name}\t{contract.amount:c}\t{contract.startDate.ToShortDateString()}\r\n";
                total += contract.amount;
            }
            str += $"Total Amount\t {total:C} ";

            return str;
        }

        //I haven't put this method anywhere 
        public string Over1000()
        {

            string str = "Contracts over $1000\r\n";
            str += $"Name\t Sales\r\n";
            var contracts = from items in AllContracts
                            where items.amount > 1000
                            select new { items.name, items.amount };

            foreach (var SignedContract in contracts)
            {
                str += $"{SignedContract.name}\t{SignedContract.amount:C}\r\n";
            }
            return str;
        }
    }
}
