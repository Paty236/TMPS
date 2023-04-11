using Factories;

public abstract class ThemeFactory
{
    public bool LightTheme = true;

    public ThemeFactory GetThemeFactory(bool LightTheme)
    {
        if (LightTheme)
        {
            return new LightThemeFactory();
        }
        else
        {
            return new DarkThemeFactory();
        }
    }

    public abstract void GetButton();

    public abstract void GetInputField();
}
