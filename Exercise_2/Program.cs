// Läser in årsmodellen.
Console.Write("Ange fordonets årsmodell: ");
int year = int.Parse(Console.ReadLine()!);

// Läser in om fordonet är försäkrat
Console.Write("Har fordonet giltig försäkring? (ja/nej): ");
string answer = Console.ReadLine()!.Trim().ToLower();

// Stoppar programmet om användaren inte svarar ja eller nej
if (answer != "ja" && answer != "nej")
{
    Console.WriteLine("Svara ja eller nej.");
    return;
}

// blir true om svaret är "ja"
bool hasInsurance = answer == "ja";

// Skapar fordonet och ger det värden
Vehicle vehicle = new Vehicle();
vehicle.Year = year;
vehicle.HasInsurance = hasInsurance;

// Kontrollerar fordonet och skriver ut resultatet
Console.WriteLine(vehicle.CheckInspection());