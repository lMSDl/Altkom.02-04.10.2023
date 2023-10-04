using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    class Client
    {
        public static void Execute()
        {
            var user = new ChatUser("Paul");
            var bot1 = new ChatBot("Alexa");
            var bot2 = new ChatBot("Siri");

            var chat = new Mediator();
            user.Mediator = chat;
            bot1.Mediator = chat;
            bot2.Mediator = chat;


            while(true)
            {
                var message = Console.ReadLine();
                var splittedMessage = message.Split(new string [] {" $ "}, StringSplitOptions.None);
                if (splittedMessage.Length > 1)
                {
                    user.Mediator.Send(user, splittedMessage[1], splittedMessage[0]);
                }
                else
                {
                    user.Mediator.Send(user, message);
                }
            }

        }
    }
}
