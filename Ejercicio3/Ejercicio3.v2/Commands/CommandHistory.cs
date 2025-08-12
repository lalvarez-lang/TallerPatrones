
namespace Ejercicio3.Commands
{
    public class CommandHistory
    {
        private List<Command> history;
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
                Command lastCommand = history.Last();
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
