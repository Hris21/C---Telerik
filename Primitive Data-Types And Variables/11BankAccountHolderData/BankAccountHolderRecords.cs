namespace BankAccountHolderData


{
    using System;

    class BankAccountHolderRecords
    {
        static void Main(string[] args)
            //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
        {
            string firstName = "";
            string middleName = "";
            string lastName = "";
            double balance = 0.0d;
            string bankName = "";
            string IBAN = "";
            string[] creditCardNumber = new string[3];
            Console.WriteLine("Account holder's first name: type = {0}",firstName.GetTypeCode());
            Console.WriteLine("Account holder's middle name: type = {0}", middleName.GetTypeCode());
            Console.WriteLine("Account holder's last name: type = {0}", lastName.GetTypeCode());
            Console.WriteLine("Account holder's balance: type = {0}",balance.GetTypeCode());
            Console.WriteLine("Account holder's bank name: type = {0}",bankName.GetTypeCode());
            Console.WriteLine("Account holder's IBAN: type = {0}",IBAN.GetTypeCode());
            Console.WriteLine("Account holder's credit card number: type = {0}", creditCardNumber.GetType()); //I apologize for using array so early, hope it is not confusing you. :) 
        }
    }
}
