using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class CommandHistory
    {
        private readonly Stack<ICommand> history = new Stack<ICommand>();
        public void Add(ICommand command)
        {
            history.Push(command);
        }
        public ICommand Undo()
        {
            if (history.Count > 0)
            {
                return history.Pop();
            }
            return null;
        }
        public bool hasCommand() =>history.Count > 0;
    }
}
