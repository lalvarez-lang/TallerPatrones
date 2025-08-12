
namespace Ejercicio3.Commands
{
    public class DeleteCommand : Command
    {
        public DeleteCommand(Entities.Task task) : base(task)
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
