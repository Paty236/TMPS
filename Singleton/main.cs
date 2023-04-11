class Program
{
    static void Main()
    {
        Singleton.Instance().LogMsg("Message 1");

        Thread thread1 = new Thread(new ThreadStart(ThreadMethod1));
        Thread thread2 = new Thread(new ThreadStart(ThreadMethod2));

        thread1.Start();
        thread2.Start();

        Singleton.Instance().LogMsg("Message 2");

        thread1.Join();
        thread2.Join();

        Console.ReadLine();
    }

    static void ThreadMethod1()
    {
        Singleton.Instance().LogMsg("Message 3 from Thread 1");
    }

    static void ThreadMethod2()
    {
        Singleton.Instance().LogMsg("Message 4 from Thread 2");
    }
}