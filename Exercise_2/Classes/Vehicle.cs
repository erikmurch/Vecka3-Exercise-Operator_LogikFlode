public class Vehicle
{
    // Fordonets årsmodell
    public int Year { get; set; }

    // Säger om fortdonet är försäkrad med true/false
    public bool HasInsurance { get; set; }

    public string CheckInspection()
    {
        // Räknar ut fordonets ålder utifrån årsmodellen
        int age = DateTime.Now.Year - Year;

        // && betyder "och". ! betyder "inte".
        if (age > 5 && !HasInsurance)
        {
            return "Ej godkänt";
        }
        else if (age < 5 && HasInsurance)
        {
            return "Godkänt";
        }
        else
        {
            return "Måste kompletteras";
        }
    }
}