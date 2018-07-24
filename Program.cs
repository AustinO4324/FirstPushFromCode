using System;

namespace Projects
{
    class Program
    {

        public enum CustomerStatus
    {
        New = 1,
        AwaitingActivation = 2,
        Activatied = 3,
        Deactivated = 4,
    }

        public struct Customer
        {
            public int ID;
            public string FirstName;
            public string LastName;
            public CustomerStatus Status;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer Cust1 = new Customer();
            Cust1.ID = 555;
            Cust1.FirstName = "Austin";
            Cust1.LastName = "O'Brien";
            Cust1.Status = CustomerStatus.New;
            Console.WriteLine($"{Cust1.ID}- {Cust1.FirstName} {Cust1.LastName}, {Cust1.Status}");
        }
    }
}
