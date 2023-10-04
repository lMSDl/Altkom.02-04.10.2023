using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    abstract class ChatMember
    {
        private IMediator mediator;

        public string Nick { get; }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public IMediator Mediator
        {
            get => mediator;
            set
            {
                mediator?.Quit(this);
                mediator = value;
                mediator?.Join(this);
            }
        }

        public abstract void Receive(string from, string message, bool isPrivate);
    }
}
