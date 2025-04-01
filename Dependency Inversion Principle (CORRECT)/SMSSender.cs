using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle__CORRECT_
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string message, string receiver)
        {
            Console.WriteLine($"SMS enviado para {receiver}: {message}");
        }
    }
}
