using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Commands
{
    public class CommandHistory
    {
        List<Command> history;
        public CommandHistory()
        {
            history = new List<Command>();
        }
        public void AddCommand(Command command)
        {
            history.Add(command);
        }
        public Command? UndoLastCommand()
        {
            if (history.Count > 0)
            {
                Command lastCommand = history[history.Count - 1];
                history.RemoveAt(history.Count - 1);
                return lastCommand;
            }
            else
            {
                Console.WriteLine("No commands to undo.");
                return null;
            }
        }
        public void ListHistory()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("No commands in history.");
                return;
            }
            Console.WriteLine("\n=====================================================");
            Console.WriteLine("Command History:");
            Console.WriteLine("=====================================================");

            foreach (var command in history)
            {
                Console.WriteLine(command.ToString());
            }

            Console.WriteLine("=====================================================\n");
        }
    }
}
