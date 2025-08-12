
namespace Ejercicio3.Commands
{
    public class EditCommand : Command
    {
        public EditCommand(Entities.Task task) : base(task)
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
