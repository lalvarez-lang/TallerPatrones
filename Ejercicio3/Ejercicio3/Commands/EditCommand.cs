using Ejercicio3.Entities;
using Ejercicio3.Invokers;

namespace Ejercicio3.Commands
{
    public class EditCommand : Command
    {
        public EditCommand(Entities.Task TaskReceiver, TaskManagementInvoker invoker) : base(TaskReceiver, invoker)
        {
        }
        public override bool Execute()
        {
            SaveBackup();
            task.Edit();
            return true;
        }
        public override string ToString()
        {
            return $"Command: Edit for {task.ToString()}";
        }
    }
}
