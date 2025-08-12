

namespace Ejercicio3.Commands
{
    public class CreateCommand : Command
    {
        public CreateCommand(Entities.Task task) : base(task)
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
