public class Account
{
    // Här sparas kontots uppgifter
    public string Username { get; private set; } = "";
    public string Password { get; private set; } = "";

    // Håller reda på om ett konto faktiskt har registrerats
    private bool isRegistered = false;

    public bool CheckPasswordStrength(string password)
    {
        // Lösenordet måste ha minst 6 tecken.
        if (string.IsNullOrEmpty(password) || password.Length < 6)
        {
            return false;
        }

        // börjar med att anta att inget av kraven är uppfyllt
        bool hasDigit = false;
        bool hasUppercase = false;
        bool hasSpecialCharacter = false;

        // Undersöker varje tecken i lösenordet
        foreach (char character in password)
        {
            if (char.IsDigit(character))
            {
                hasDigit = true;
            }

            if (char.IsUpper(character))
            {
                hasUppercase = true;
            }

            if (char.IsPunctuation(character) || char.IsSymbol(character))
            {
                hasSpecialCharacter = true;
            }
        }

        // Alla tre kraven måste vara uppfyllda
        return hasDigit && hasUppercase && hasSpecialCharacter;
    }

    public bool Register(string username, string password)
    {
        // Nekar tomt användarnamn eller ett för svagt lösenord
        if (string.IsNullOrWhiteSpace(username) ||
            !CheckPasswordStrength(password))
        {
            return false;
        }

        // Sparar uppgifterna när registreringen lyckas
        Username = username;
        Password = password;
        isRegistered = true;
        return true;
    }

    public bool Login(string username, string password)
    {
        // Det måste finnas ett registrerat konto,
        // och båda uppgifterna måste stämma
        return isRegistered &&
               Username == username &&
               Password == password;
    }
}