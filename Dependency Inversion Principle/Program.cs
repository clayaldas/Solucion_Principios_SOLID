namespace Dependency_Inversion_Principle
{  
  // Ejemplo mal aplicado - Violación del DIP

  // Clase de bajo nivel
  public class EmailSender
  {
    public void SendEmail(string message, string receiver)
    {
      // Lógica para enviar correo electrónico
      Console.WriteLine($"Email enviado para {receiver}: {message}");
    }
  }

  // Clase de alto nivel
  public class NotificationService
  {
    private EmailSender emailSender;

    public NotificationService()
    {
      this.emailSender = new EmailSender();
    }

    public void SendNotification(string message, string receiver)
    {
      emailSender.SendEmail(message, receiver);
    }
  } 

  class Program
  {
    static void Main(string[] args)
    {
      NotificationService service = new NotificationService();
      service.SendNotification("!!Hola que tal!!", "user@google.com");
    }
  }

}
