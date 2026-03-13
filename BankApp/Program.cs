using System;

namespace BankApp;

class Program
{
    static void Main(string[] args)
    {
        start();
        
    }
    
    public static void start()
    {
    // start of the program 
    List<BankAccount> accounts = new List<BankAccount>();
    {
        // accounts in the list 
        accounts.Add(new BankAccount("123", 299.0, "4567", "sanele"));
        accounts.Add(new BankAccount("675389", 66666.0, "9897", "mike"));
    };
    Console.WriteLine("  Welcome to Absa Banking app");
    Console.WriteLine("=====================================");
    // enter account number 
    Console.WriteLine("ENTER ACCOUNT NUMBER:");
    string accNumber =  Console.ReadLine();
    
    // ask user for pin and 
    Console.WriteLine("ENTER PIN:");
    String pin =  Console.ReadLine();
    
    Console.WriteLine("=====================================");
    // find account
    BankAccount findAccount = accounts.Find(acc => acc.AccountNumber == accNumber && pin == pin);
    //if account is not found
    if (findAccount != null)
    {
        // greet account holder
        Console.WriteLine($"Welcome { findAccount.accountHolder }!");
        
        int choice;
        
        do
        {
            // menu items
            Console.WriteLine("What  would you like to do?");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.WriteLine("chose an option:");
            
            choice = Convert.ToInt32(Console.ReadLine());
            //checking if input is in between 1-4 
        } while (choice < 1 || choice > 4);

        switch (choice)
        {
            case 1: //deposit
                Console.WriteLine("Enter the amount of money you want to deposit:");
                double money = double.Parse(Console.ReadLine());
                findAccount.deposit(money);
                Console.WriteLine("R " +money+ " SUCCESSFULLY DEPOSITED!");
                Console.WriteLine("====================");
                Console.WriteLine("Balance: R "+ findAccount.Balance);
                start();
                break;
            case 2:  // Withdraw
                Console.WriteLine("Enter the amount of money you are withdrawing:");
                double withdrawAmount = double.Parse(Console.ReadLine());
                findAccount.withdraw(withdrawAmount);
                start();
                break;
            
            case 3:  // Check Balance
                findAccount.checkBalance();
                start();
                break;
            case 4: // exist
                Console.WriteLine("closing application.....");
                break;
        }
    }


    }

   

}





// withdraw , deposit , check balance 
