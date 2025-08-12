using Ejercicio3.Entities;
using Ejercicio3.Invokers;

namespace Ejercicio3.Commands
{
    public abstract class Command
    {
        public Entities.Task task { get; set; }
        private Entities.Task taskBackup { get; set; }
        protected TaskManagementInvoker invoker;

        public Command(Entities.Task TaskReceiver, TaskManagementInvoker invoker)
        {
            this.task = TaskReceiver;
            taskBackup = new Entities.Task(TaskReceiver.id, TaskReceiver.name);
            this.invoker = invoker;
        }
        public void SaveBackup()
        {
            taskBackup.id = task.id;
            taskBackup.name = task.name;
        }
        public void Undo()
        {
            task.id = taskBackup.id;
            task.name = taskBackup.name;
        }

        public override string ToString()
        {
            return $"Command for {task.ToString()}";
        }
        public abstract bool Execute();
    }
}
