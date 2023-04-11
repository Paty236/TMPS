namespace Factories
{
    public class DarkThemeFactory: ThemeFactory
    {
        public DarkThemeFactory()
        {
        }

        public override void GetButton()
        {
            Console.WriteLine("Am apasat pe butonul Dark");
        }

        public override void GetInputField()
        {
            Console.WriteLine("Scrie ceva pe fundal inchis:");
        }
    }
}
