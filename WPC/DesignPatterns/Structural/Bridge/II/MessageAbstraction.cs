using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Bridge.II
{
    class MessageAbstraction
    {
        private IMessageSenderImplenetation messageSender;
        public MessageAbstraction(IMessageSenderImplenetation messageSender)
        {
            this.messageSender = messageSender;
        }

        public void Send(string message)
        {
            messageSender.SendMessage(message);
        }
    }
}
