public class SavingsAccount : BankAccount {

    //constuctor
    public SavingsAccount(string NewOwnersName, double initialBalance) 
    : base(NewOwnersName, initialBalance)
    {
this.Deposit(100.00); // give extra $100
    }
}

public class CheckingAccount : BankAccount {
    //constructor
    public CheckingAccount(string NewOwnersName, double initialBalance)
    : base(NewOwnersName, initialBalance)
    {
        
    }
}