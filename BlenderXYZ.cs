using System;
using static System.Console;

namespace BlenderXYZ 
{
    internal class program 
    {
        static void Main(string[] args) 
        {
            WriteLine("-------------------------Task 1-------------------------");

            WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&\n&                         &\n& Make your things smooth &\n&                         &\n&&&&&&&&&&&&&&&&&&&&&&&&&&&");

            WriteLine("-------------------------Task 2-------------------------");

            //Declare variables
            string Name, StreetAddress, City, PostCode, State;
            int OrderNo;
            double BlendPerCost = 35.50, AmountDue, SalesTax, NetDue;

            //Receipt info
            Write("Name: ");
            Name = ReadLine();

            Write("Street Address: ");
            StreetAddress = ReadLine();

            Write("City: ");
            City = ReadLine();

            Write("Post Code: ");
            PostCode = ReadLine();

            Write("State: ");
            State = ReadLine();

            Write("Blender Quantity: ");
            OrderNo = Convert.ToInt32(ReadLine());

            AmountDue = BlendPerCost * OrderNo;
            SalesTax = AmountDue * 0.05;
            NetDue = AmountDue + SalesTax;

            WriteLine("-------------------------Task 3-------------------------");

            WriteLine("Receipt for: \n {0} \n {1} \n {2} \n {3} \n {4}", Name, StreetAddress, City, PostCode, State);
            WriteLine("\n--------------------------------------------------------\n");
            WriteLine("{0} blenders ordered at $35.50 each \n", OrderNo);
            WriteLine("Total:          \t${0}", AmountDue.ToString("F2"));
            WriteLine("Tax:            \t${0}", SalesTax.ToString("F2"));
            WriteLine("--------------------------------------------------------");
            WriteLine("Total due:      \t${0}", NetDue.ToString("F2"));
        }
    }
}