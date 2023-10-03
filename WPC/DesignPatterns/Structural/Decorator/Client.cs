using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Decorator
{
    class Client
    {
        public static void Execute()
        {
            while (true)
            {
                var text = Console.ReadLine();

                INotification notification = new Notification();
                if (text.Length <= 16)
                    notification = new SmsNotification(notification);
                if (Random())
                    notification = new EmailNotification(notification);


                notification.Send(text);
            }
        }

        private static bool Random()
        {
            return DateTime.UtcNow.Second % 2 == 0;
        }
    }
}
