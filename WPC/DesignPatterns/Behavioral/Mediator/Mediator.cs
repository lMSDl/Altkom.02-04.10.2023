using System.Collections.Generic;
using System.Linq;

namespace WPC.DesignPatterns.Behavioral.Mediator
{
    class Mediator : IMediator
    {
        private readonly ICollection<ChatMember> _chatMembers = new List<ChatMember>();

        public void Join(ChatMember chatMember)
        {
            _chatMembers.Add(chatMember);
        }

        public void Quit(ChatMember chatMember)
        {
            _chatMembers.Remove(chatMember);
        }

        public void Send(ChatMember chatMember, string message)
        {
            var query = _chatMembers.Where(x => x != chatMember);
            if (chatMember is ChatBot)
                query = query.Where(x => !(x is ChatBot));
            query
                .ToList()
                .ForEach(x => x.Receive(chatMember.Nick, message, false));
        }

        public void Send(ChatMember chatMember, string message, string to)
        {
            _chatMembers.SingleOrDefault(x => x.Nick == to).Receive(chatMember.Nick, message, true);
        }
    }
}
