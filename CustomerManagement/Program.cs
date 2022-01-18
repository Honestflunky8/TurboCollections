

using TurboCollections;
using TurboStack;

namespace CustomerManagement
{
    class Program
    {
        static TurboList<string> _customerList = new TurboList<string>();
        static bool wantsToQuit;
        static void Main(string[] args)
        {
            StartUpMessage();
            while (!wantsToQuit)
            {
                OptionsDisplay();
            }

            QuitMessage();
        }

        static void QuitMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Have a pleasant day!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The program will now close");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static public void StartUpMessage()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
        }
        
        static public void OptionsDisplay()
        {
            Console.WriteLine("Your options are: ");
            Console.WriteLine("Adding a Customer (1)");
            Console.WriteLine("Removing a Customer by name (2)");
            Console.WriteLine("Removing a Customer by index (3)");
            Console.WriteLine("Retrieving all Customers from the Database (4)");
            Console.WriteLine("Exit Program (5)");
            var response = Console.ReadLine();
            if (response == "1") // Add Customer
            {
                AddingCustomer();
            }

            else if (response == "2") // Remove Customer by Name
            {
                RemovingCustomerByName();
            }
            else if (response == "3") // Remove Customer by Index
            {
                RemovingCustomerByIndex();
            }
            else if (response == "4") // Retrieving all Customers
            {
                RetrievingAllCustomers();
            }
            else if (response == "5")
            {
                wantsToQuit = true;
            }
            else
            {
                Console.WriteLine("Please give a valid input. (1/2/3/4)");
            }
            
        }
        static void AddingCustomer()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What's the Name of the Customer you would like to add to the Customer list?");
            var response = Console.ReadLine().ToLower();
            AddCustomer(response);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void RemovingCustomerByName()
       {
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.WriteLine("What's the Name of the Customer you would like to remove from the Customer list?");
           var response = Console.ReadLine().ToLower();
           RemoveCustomer(response);
           Console.ForegroundColor = ConsoleColor.White;
       }
        
        static void RemovingCustomerByIndex()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What's the Index of the Customer you would like to remove from the Customer list?");
            var response = Console.ReadLine();
            RemoveCustomer(Convert.ToInt32(response));
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void RetrievingAllCustomers()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Here's a list of all current Customers in the database:");
            GetAllCustomers();
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        static public void AddCustomer(string name)
        {
            _customerList.Add(name);
            Console.WriteLine($"Customer {name} has been added to the Customer list.");
        }

        static public void RemoveCustomer(string name)
        {
            if (_customerList.Contains(name))
            {
                _customerList.Remove(name);
                Console.WriteLine($"Customer {name} has been removed from the Customer list.");
            }
            
            else
            {
                Console.WriteLine($"The name {name} does not exist in the Customer list.");
            }
           
        }
        static public void RemoveCustomer(int index)
        {
            if (index <= _customerList.Lenght)
            {
                _customerList.RemoveAt(index);
                var customerName = _customerList.Get(index);
                Console.WriteLine($"Customer {customerName} at index: {index} has been removed from the Customer list.");
            }
            else
            {
                Console.WriteLine("This index does not exist in the Customer list.");
            }
        }

        static public void GetAllCustomers()
        {
            if (_customerList.Count == 0)
            {
                Console.WriteLine("There currently exist no customers in the database");
                return;
            }
            for (var i = 0; i < _customerList.Count; i++)
            {
                Console.WriteLine(_customerList.Get(i));
                
            }
        }
        
        
        // (1) Add a Customer
        //     (2) Remove a Customer by name
        //     (3) Remove a Customer by index
        //     (4) Display all Customers
    }
}