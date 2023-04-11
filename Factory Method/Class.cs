using System;

namespace ExampleNamespace
{
    public interface ITheme
    {
        string GetColor();
    }

    public class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Light";
        }
    }

    public class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark";
        }
    }

    public class Window
    {
        public Window(int x, int y)
        {
        }

        public virtual ITheme GetUITheme()
        {
            return new DarkTheme();
        }

        public void Paint()
        {
            ITheme theme = GetUITheme();
            Console.WriteLine($"Paint with {theme.GetColor()} color");
        }
    }

    public class LightWindow : Window
    {
        public LightWindow(int x, int y) : base(x, y)
        {
        }

        public override ITheme GetUITheme()
        {
            return new LightTheme();
        }
    }
}
