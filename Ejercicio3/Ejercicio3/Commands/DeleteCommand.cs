using Ejercicio3.Entities;
using Ejercicio3.Invokers;

namespace Ejercicio3.Commands
{
    public class DeleteCommand : Command
    {
        public DeleteCommand(Entities.Task TaskReceiver, TaskManagementInvoker invoker) : base(TaskReceiver, invoker)
        {
        }
        public override bool Execute()
        {
            SaveBackup();
            task.Delete();
            return true;
        }
        public override string ToString()
        {
            return $"Command: Delete for {task.ToString()}";
        }
    }
}
