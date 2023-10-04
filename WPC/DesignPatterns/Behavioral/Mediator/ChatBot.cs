using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    class ChatBot : ChatMember
    {
        public ChatBot(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if(isPrivate)
            {
                Mediator.Send(this, message, from);
            } else
            {
                Mediator.Send(this, message);
            }
        }
    }
}
