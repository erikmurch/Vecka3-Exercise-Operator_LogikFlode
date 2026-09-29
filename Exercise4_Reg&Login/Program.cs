// Skapa ett konto utanför loopen så uppgifterna finns kvar
// när användaren går från registrering till inloggning.
Account account = new Account();
bool running = true;

while (running)
{
    // Visa menyn och läs användarens val.
    MenuHelper.ShowMenu();
    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            // Registrering: läs uppgifter och försök skapa kontot
            Console.Write("Användarnamn: ");
            string newUsername = Console.ReadLine() ?? "";

            Console.Write("Lösenord: ");
            string newPassword = Console.ReadLine() ?? "";

            if (account.Register(newUsername, newPassword))
            {
                Console.WriteLine("Registreringen lyckades!");
            }
            else
            {
                Console.WriteLine(
                    "Registreringen misslyckades. Lösenordet behöver " +
                    "minst 6 tecken, en siffra, en stor bokstav och " +
                    "ett specialtecken. Användarnamnet får inte vara tomt.");
            }
            break;

        case "2":
            // Inloggning: jämför uppgifterna med det sparade kontot
            Console.Write("Användarnamn: ");
            string username = Console.ReadLine() ?? "";

            Console.Write("Lösenord: ");
            string password = Console.ReadLine() ?? "";

            if (account.Login(username, password))
            {
                Console.WriteLine("Inloggning lyckades!");
            }
            else
            {
                Console.WriteLine("Felaktiga uppgifter.");
            }
            break;

        case "3":
            // Sätt running till false så att while-loopen avslutas
            running = false;
            Console.WriteLine("Programmet avslutas.");
            break;

        default:
            Console.WriteLine("Välj 1, 2 eller 3.");
            break;
    }
}