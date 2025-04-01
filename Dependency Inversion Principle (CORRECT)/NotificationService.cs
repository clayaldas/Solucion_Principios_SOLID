using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle__CORRECT_
{
    public class NotificationService
    {
        private readonly IMessageSender _messageSender;//inmutable

        public NotificationService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void SendNotification(string message, string receiver)
        {
            _messageSender.SendMessage(message, receiver);
        }
    }
}
