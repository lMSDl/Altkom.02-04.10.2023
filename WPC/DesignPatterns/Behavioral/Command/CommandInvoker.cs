using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    class CommandInvoker
    {
        private readonly static Stack<ICommand> _commands = new Stack<ICommand>();
        private readonly ICommand _command;
        public CommandInvoker(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            if(_command.Execute())
                _commands.Push(_command);
        }

        public static void Undo()
        {
            var command = _commands.Pop();
            command?.Reverse();
        }
    }
}
