
namespace Ejercicio3.Commands
{
    public class CompleteCommand : Command
    {
        public CompleteCommand(Entities.Task task) : base(task)
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
