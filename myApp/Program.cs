using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Kurt";
            var lastName = "Miller";

            var FullName = firstName + " " + lastName;

            var myFullName = string.Format(" My Name is {0} {1}", firstName, lastName);

            var names = new string[3] { "john", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);
            System.Console.WriteLine(formattedNames);
            System.Console.WriteLine(myFullName);

            var text = "Hello John\n Look into the following PATHS\n d:\\UI Class\n d:\\UI Class\\Projects\n d:\\UI Class\\Projects\\myApp";
            System.Console.WriteLine(text);            
        
            var altText = @"Hello John Look into the following PATHS
        d:\UI Class 
        d:\UI Class\Projects                
        d:\UI Class\Projects\myApp"; //Much smoother and fluid using a verbatum string
            System.Console.WriteLine(altText);

        }
    }
}