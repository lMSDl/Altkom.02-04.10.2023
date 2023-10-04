using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    interface IMediator
    {
        void Join(ChatMember chatMember);
        void Quit(ChatMember chatMember);
        void Send(ChatMember chatMember, string message);
        void Send(ChatMember chatMember, string message, string to);
    }
}
