using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    class ChatUser : ChatMember
    {
        public ChatUser(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            Console.WriteLine($"{from}{(isPrivate ? $" to {Nick}" : "")}: {message}");
        }
    }
}
