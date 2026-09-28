public class BankAccount
{
    // Saldot ska börja på 0
    // private set betyder att bara klassen får ändra saldot
    public decimal Balance { get; private set; } = 0;

    public bool Deposit(decimal amount)
    {
        // Man får bara sätta in ett belopp större än 0
        if (amount <= 0)
        {
            return false;
        }

        Balance += amount;
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        // Neka negativa belopp och uttag som är större än saldot
        if (amount <= 0 || amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }
}