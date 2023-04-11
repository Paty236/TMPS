using System;
using static Message;

class Program
{
    static void Main(string[] args)
    {
      Message message = Message.With()
         .WithSender("mamsaturatdelaboratoare@gmail.com")
         .WithReceiver("receiver1@example.com")
         .WithReceiver("receiver2@example.com")
         .WithSubject("Buna ziua!")
         .WithBody("Multumim pentru ca a-ti ales UTM! :) ")
         .Build();

        Console.WriteLine(message.Sender);
        Console.WriteLine(message.Subject);
        Console.WriteLine(message.Body);

        Console.ReadKey();
    }
}
