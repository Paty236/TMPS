using Factories;

class Program
{
    static void Main(string[] args)
    {
        // Instantiem fabricile
        DarkThemeFactory darkThemeFactory = new DarkThemeFactory();
        LightThemeFactory lightThemeFactory = new LightThemeFactory();

        // Cream butoane si campuri de intrare pentru fiecare tema
        darkThemeFactory.GetButton();
        lightThemeFactory.GetButton();

        darkThemeFactory.GetInputField();
        lightThemeFactory.GetInputField();

        Console.ReadKey();
    }
}
