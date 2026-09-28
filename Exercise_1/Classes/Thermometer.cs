public class Thermometer
{
    // Här sparas temperaturen för classen
    public int Temperature { get; set; }

    // Metoden väljer en text utifrån temperaturen
    public string CheckTemperature()
    {
        if (Temperature < 0)
        {
            return "Det är minusgrader";
        }
        else if (Temperature <= 30)
        {
            return "Normal temperatur";
        }
        else
        {
            return "Hög tempratur";
        }
    }
}
