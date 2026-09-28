// Skapar ett bankkonto med startsaldo 0
BankAccount account = new BankAccount();
bool running = true;

// Fortsätter att visa menyn tills användaren väljer att avsluta
while (running)
{
    MenuHelper.ShowMenu();
    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.Write("Hur mycket vill du sätta in? ");

            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount)
                && account.Deposit(depositAmount))
            {
                Console.WriteLine("Insättningen lyckades.");
            }
            else
            {
                Console.WriteLine("Ange ett giltigt belopp större än 0.");
            }
            break;

        case "2":
            Console.Write("Hur mycket vill du ta ut? ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
            {
                Console.WriteLine("Ange ett giltigt belopp.");
            }
            else if (account.Withdraw(withdrawalAmount))
            {
                Console.WriteLine("Uttaget lyckades.");
            }
            else
            {
                Console.WriteLine("Uttaget nekades. Kontrollera beloppet och saldot.");
            }
            break;

        case "3":
            Console.WriteLine($"Ditt saldo är {account.Balance} kr.");
            break;

        case "4":
            running = false;
            Console.WriteLine("Programmet avslutas.");
            break;

        default:
            Console.WriteLine("Välj 1, 2, 3 eller 4.");
            break;
    }
}