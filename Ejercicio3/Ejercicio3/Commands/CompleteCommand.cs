using Ejercicio3.Entities;
using Ejercicio3.Invokers;

namespace Ejercicio3.Commands
{
    public class CompleteCommand : Command
    {
        public CompleteCommand(Entities.Task TaskReceiver, TaskManagementInvoker invoker) : base(TaskReceiver, invoker)
        {
        }
        public override bool Execute()
        {
            SaveBackup();
            task.Complete();
            return true;
        }
        public override string ToString()
        {
            return $"Command: Complete for {task.ToString()}";
        }
    }
}
