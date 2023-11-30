public class BankAccount {
   private double Balance = 0;
   public string OwnersName = "";
    //constructor
    public BankAccount (string NewOwnersName, double initialBalance){
        this.OwnersName = NewOwnersName;
        this.Deposit(initialBalance);
        //this.Deposit(100.00);
}
    public double Deposit (double amount){
        if (amount < 0.00)
        {
            throw new Exception("Nope");
        }
        this.Balance += amount;
        return this.Balance;
    }
    public double Withdraw (double amount){
        if (amount < 0.00){
            throw new Exception("No Negativity");
        }
        if (amount > this.Balance){
            throw new Exception("You dont have that much! hahaha");
        }
        this.Balance -= amount;
        return this.Balance;
    }
public double getBalance (){
    return this.Balance;
}
}












