namespace ProblemEmployeeData


{
    using System;

    class EmployeeRecords
    {
        static void Main(string[] args)
            //A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, last name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
        {
            string firstName = "";          //Easy task here, we just have to choose the right data type for each characteristic.
            string familyName = "";
            byte age = 0;
            char gender = '\u0000';
            int idNumber = 0;
            uint uniqueEmployeeNumber = 0;

            Console.WriteLine("Employee's first name: type = {0}", firstName.GetTypeCode());   
            Console.WriteLine("Employee's family name: type = {0}", familyName.GetTypeCode());
            Console.WriteLine("Employee's age: type = {0}", age.GetTypeCode());
            Console.WriteLine("Employee's gender: type = {0}", gender.GetTypeCode());
            Console.WriteLine("Employee's ID number: type = {0}", idNumber.GetTypeCode());
            Console.WriteLine("Employee's Unique employee number: type = {0}", uniqueEmployeeNumber.GetTypeCode()); 

        }
    }
}
