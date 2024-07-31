using System;
namespace NamingObjectsProperties
{
    class Project
    {
        static void Main(string[] args)
        {
            //Naming Conventions
            //Camel Case title case
            string firstName = "Farjia";
            Console.WriteLine(firstName);

            //Pascal Case or Upper Camel Case
            string MiddleName = "Ahamed";
            Console.WriteLine(MiddleName);

            //Uderscore or Snake Case with lower case = not recommended
            string last_name = "Dristy";
            Console.WriteLine(last_name);

            //Kebab Case which isn't supported by VS.
            //int first-number = 200;
            //make code more readable and understandable
            //avoid conflicted keywords that match with the coding identifiers/functions
            //avoid using special symbols
        }
    }
}
