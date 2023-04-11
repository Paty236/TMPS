using ExampleNamespace;

Window darkWindow = new(10, 10);
darkWindow.Paint();

Window lightWindow = new LightWindow(20, 20);
lightWindow.Paint();

Console.ReadKey();