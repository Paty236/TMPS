using System;
using System.IO;
using System.Threading;

public class Singleton
{
    private static Singleton _instance;
    private static readonly object _padlock = new object();

    private Singleton()
    {
        
    }

    public static Singleton Instance()
    {
        if (_instance == null)
        {
            lock (_padlock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
            }
        }
        return _instance;
    }

    public void LogMsg(string logMsg)
    {
        lock (_padlock)
        {
            Console.WriteLine(logMsg);
        }
    }
}

