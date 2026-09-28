// Frågar användaren efter en temperatur
Console.Write("Ange temperatur: ");
// Omvandlar texten till tal och skapar en variabel
int temperature = int.Parse(Console.ReadLine()!);

// Skapar en termometer och sätter dess temperatur
Thermometer thermometer = new Thermometer();
thermometer.Temperature = temperature;

// Kontrollerar temperaturen och skriver ut resultatet
Console.WriteLine(thermometer.CheckTemperature());