namespace SOLID__CORRECT_
{
    // 4. Aplicamos LSP: Cada clase derivada (heradada) sigue funcionando sin romper el 
    //    el comportamiento esperado.
    public class EmailSender : IEmailSender
    {
        public void SendEmail()
        {
            Console.WriteLine("Enviando el correo electrónico...");
        }
    }
}
