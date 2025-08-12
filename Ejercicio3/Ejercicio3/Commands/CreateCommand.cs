using Ejercicio3.Entities;
using Ejercicio3.Invokers;

namespace Ejercicio3.Commands
{
    public class CreateCommand : Command
    {
        public CreateCommand(Entities.Task TaskReceiver, TaskManagementInvoker invoker) : base(TaskReceiver, invoker)
        {
        }

        public override bool Execute()
        {
            SaveBackup();
            task.Create();
            return true;
        }
        public override string ToString()
        {
            return $"Command: Create for {task.ToString()}";
        }
    }
}
