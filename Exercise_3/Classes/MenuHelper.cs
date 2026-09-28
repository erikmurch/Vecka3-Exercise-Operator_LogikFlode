static class MenuHelper
{
    // Detta är bara menyn, användarens val 
    public static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Insättning");
        Console.WriteLine("2. Uttag");
        Console.WriteLine("3. Visa saldo");
        Console.WriteLine("4. Avsluta");
        Console.Write("Välj ett alternativ: ");
    }
}