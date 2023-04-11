public class Message
{
    public string Sender;
    public List<string> Receivers = new List<string>();
    public string Subject;
    public string Body;

    private Message() { }

    public static MessageBuilder With()
    {
        return new MessageBuilder();
    }

    public class MessageBuilder
    {
        private readonly Message _message = new Message();

        public MessageBuilder WithSender(string sender)
        {
            _message.Sender = sender;
            return this;
        }

        public MessageBuilder WithReceiver(string receiver)
        {
            _message.Receivers.Add(receiver);
            return this;
        }

        public MessageBuilder WithSubject(string subject)
        {
            _message.Subject = subject;
            return this;
        }

        public MessageBuilder WithBody(string body)
        {
            _message.Body = body;
            return this;
        }

        public Message Build()
        {
            if (string.IsNullOrEmpty(_message.Subject))
                Console.WriteLine("Precis vrei sa transmiti mesajul fara subiect");

            return _message;
        }
    }
}