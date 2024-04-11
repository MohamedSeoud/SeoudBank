// See https://aka.ms/new-console-template for more information
using SeoudBank.Presenation;


//Application execution starts here

    //display title
    Console.WriteLine("************** Seoud Bank *****************");
    Console.WriteLine("::Login Page::");

    //declare variables to store username and password;
    string userName = null, password = null;

    //read userName from keyboard
    Console.Write("Username: ");
    userName = Console.ReadLine();

    //read password from keyboard only if username is entered
    if (userName != "")
    {
        Console.Write("Password: ");
        password = Console.ReadLine();
    }

    //check username and password
    if (userName == "system" && password == "manager")
    {
        //declare variable to store menu choice
        int mainMenuChoice = -1;

        do
        {
            //show main menu
            Console.WriteLine("\n:::Main menu:::");
            Console.WriteLine("1. Customers");
            Console.WriteLine("2. Accounts");
            Console.WriteLine("3. Funds Transfer");
            Console.WriteLine("4. Funds Transfer Statement");
            Console.WriteLine("5. Account Statement");
            Console.WriteLine("0. Exit");

            //accept menu choice from keyboard
            Console.Write("Enter choice: ");
            mainMenuChoice = int.Parse(Console.ReadLine());

            //switch-case to check menu choice
            switch (mainMenuChoice)
            {
                case 1: CustomersMenu(); break;
                case 2: AccountsMenu(); break;
                case 3: //TO DO: Display funds transfer menu
                    break;
                case 4: //TO DO: Display funds transfer statement menu
                    break;
                case 5: //TO DO: Display account statement menu
                    break;
            }
        } while (mainMenuChoice != 0);
    }
    else
    {
        Console.WriteLine("Invalid username or password");
    }

    //about to exit
    Console.WriteLine("Thank you! Visit again.");
    Console.ReadKey();

static void CustomersMenu()
{
    //variable to store customers menu choice
    int customerMenuChoice = -1;

    //do-while loop starts
    do
    {
        //print customers menu
        Console.WriteLine("\n:::Customers menu:::");
        Console.WriteLine("1. Add Customer");
        Console.WriteLine("2. Delete Customer");
        Console.WriteLine("3. Update Customer");
        Console.WriteLine("4. Search Customers");
        Console.WriteLine("5. View Customers");
        Console.WriteLine("0. Back to Main Menu");

        //accept customers menu choice
        Console.Write("Enter choice: ");
        customerMenuChoice = Convert.ToInt32(Console.ReadLine());

        //switch case
        switch (customerMenuChoice)
        {
            case 1: CustomersPresentation.AddCustomer(); break;
            case 5: CustomersPresentation.ViewCustomers(); break;
        }
    } while (customerMenuChoice != 0);
}


static void AccountsMenu()
{
    //variable to store accounts menu choice
    int accountsMenuChoice = -1;

    //do-while loop starts
    do
    {
        //print  accounts menu
        Console.WriteLine("\n:::Accounts menu:::");
        Console.WriteLine("1. Add Account");
        Console.WriteLine("2. Delete Account");
        Console.WriteLine("3. Update Account");
        Console.WriteLine("4. View Accounts");
        Console.WriteLine("0. Back to Main Menu");

        //accept accounts menu choice
        Console.Write("Enter choice: ");
        accountsMenuChoice = Convert.ToInt32(Console.ReadLine());
    } while (accountsMenuChoice != 0);
}