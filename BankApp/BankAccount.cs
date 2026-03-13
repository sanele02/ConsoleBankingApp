using System.Globalization;

namespace BankApp;

public class BankAccount
{
    //   account number, balance,pin, account holder
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public string pin { get; set; }
    public string accountHolder { get; set; }

    // constructor 
    public BankAccount(string accountNumber, double balance, string pin, string accountHolder)
    {
        this.AccountNumber = accountNumber;
        this.Balance = balance;
        this.accountHolder = accountNumber;
        this.pin = pin;
    }
    

    // functions 
    // withdraw , deposit , check balance 
    // withdraw
    public double withdraw(double amount)
    {
        double newBalance;
        // check if withdrawal amount is not a negative number, 0 and is not less then the balance 
        if (amount > 0 && amount <= this.Balance)
        {
            newBalance = this.Balance -amount;
            this.Balance = newBalance;

            Console.WriteLine($"Withdrawal of R {amount} was successful!");
            //show current balance
            Console.WriteLine($"Remaining balance: R {this.Balance}");
            
        }
        else
        {
            Console.WriteLine("Withdrawal was unsuccessful!"); 
        }
        // update the balance 
        return this.Balance;
    }
    
    // deposit 
    public double deposit(double amount)
    {
        // user can deposit any amount > 0
        double newbalance;
        // add old balance with the new amount that was deposited
        newbalance = amount+this.Balance;
        this.Balance = newbalance;
        
        // update the balance 
        return this.Balance;
    }
// display the balance 
    public void checkBalance()
    {
        // display the account balance
        Console.WriteLine($"Balance :  R{this.Balance}");
    }


}

