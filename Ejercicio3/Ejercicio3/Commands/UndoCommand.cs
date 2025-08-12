using Ejercicio3.Entities;
using Ejercicio3.Invokers;

namespace Ejercicio3.Commands
{
    public class UndoCommand : Command
    {
        public UndoCommand(Entities.Task TaskReceiver, TaskManagementInvoker invoker) : base(TaskReceiver, invoker)
        {
        }
        public override bool Execute()
        {
            invoker.Undo();
            return false;
        }
        public override string ToString()
        {
            return $"Command: Undo for {task.ToString()}";
        }
    }
}
