namespace Factories
{
    public class LightThemeFactory: ThemeFactory
    {
        public LightThemeFactory()
        {
        }

        public override void GetButton()
        {
            Console.WriteLine("Am apasat pe butonul Light");
        }

        public override void GetInputField()
        {
            Console.WriteLine("Scrie ceva pe fundal deschis:");
        }
    }
}
