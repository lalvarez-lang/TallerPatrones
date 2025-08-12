using Ejercicio3.Commands;

namespace Ejercicio3.Invokers
{
    public class TaskManagementInvoker
    {
        private Command _command;
        private CommandHistory _history;

        public CommandHistory History { get => _history; set => _history = value; }

        public TaskManagementInvoker(CommandHistory history)
        {
            _history = history;
        }
        public void SetCommand(Command command)
        {
            if (command == null)
            {
                Console.WriteLine("Command cannot be null.");
                return;
            }
            _command = command;
        }
        public void ExecuteCommand()
        {
            if (_command.Execute())
                History.AddCommand(_command);
        }
        public void Undo()
        {
            Command? command = History.UndoLastCommand();
            if (command != null)
            {
                command.Undo();
                Console.WriteLine($"Undo executed for {command.task.ToString()}");
            }
            else
            {
                Console.WriteLine("No command to undo.");
            }
        }
    }
}
