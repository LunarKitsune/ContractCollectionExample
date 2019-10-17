using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract_Collection_Example
{
    class ContractFile
    {
        public void WriteFile(ContractCollection contractColl)
        {
            /*A good practice is to use these objects in a using statement so that the unmanaged resources are correctly disposed. The using statement automatically calls Dispose on the object when the code that is using it has completed
             */
            //source: https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=netframework-4.8

            string fileName = "contract.txt";

            using (StreamWriter fileWriter = File.CreateText(fileName))
            {
                foreach (Contract aContract in contractColl.AllContracts)
                {
                    //each othe commas here delimit the file to seperate the information
                    //when the file is read we can use .split method in reading to seperate
                    //each word into an index
                    fileWriter.Write(aContract.number);
                    fileWriter.Write(",");
                    fileWriter.Write(aContract.name);
                    fileWriter.Write(",");
                    fileWriter.Write(aContract.amount);
                    fileWriter.Write(",");
                    fileWriter.WriteLine(aContract.startDate.ToShortDateString());
                }
            }
        }


        public void ReadFile(ContractCollection contractColl)
        {
            //the using example was used in the writer, but the same thing can applied here,
            //but for all purposes of showing what the other way looks like I will leave this example
            //more open to the intended way the professor wants the code written. 

            //Here the reader variable is created, a delimiter is set up, and
            //string line will hold each line read in the file. 
            StreamReader infile;
            string file = "contract.txt";
            char delimiter = ',';           
            string line;
            string[] fields = new string[4];
 
            //File existance is checked with File.Exists
            if (File.Exists(file))
            {
                //here if the file exists, the file is opened and read it until
                //the end of the file stream is reached
                infile = File.OpenText(file);
                while (!infile.EndOfStream)
                {
                    //Step one: Put a file line in the string line

                    //Step Two: split words into an array of words(in this case fields)
                    //and instantiate the contract object

                    //Step Three: Insert strings into appropriate places
                    //of the contract object and add the contract to the contract
                    //collection
                    line = infile.ReadLine();
                    fields = line.Split(delimiter);
                    Contract aContract = new Contract();

                    aContract.number = fields[0];
                    aContract.name = fields[1];
                    aContract.amount = double.Parse(fields[2]);
                    aContract.startDate = DateTime.Parse(fields[3]);

                    contractColl.AddContract(aContract);
                }
                infile.Close();
            }
        }
    }
}
