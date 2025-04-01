namespace Dependency_Inversion_Principle__CORRECT_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageSender emailSender = new EmailSender();

            NotificationService service = 
                new NotificationService(emailSender);
            service.SendNotification("!!Hola que tal!!", "user@google.com");

            IMessageSender smsSender = new SMSSender();
            NotificationService service1 = new NotificationService(smsSender);
            service1.SendNotification("!!Hola que tal!!", "PETER PARKER");
        }
    }
}
