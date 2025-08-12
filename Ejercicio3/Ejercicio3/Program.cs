using Ejercicio3.Commands;
using Ejercicio3.Invokers;

internal class Program
{
    private static void Main(string[] args)
    {
        CommandHistory history = new CommandHistory();
        TaskManagementInvoker invoker = new TaskManagementInvoker(history);
        Ejercicio3.Entities.Task task1 = new Ejercicio3.Entities.Task(1, "Task 1");
        Ejercicio3.Entities.Task task2 = new Ejercicio3.Entities.Task(1, "Task 2");

        Command createCommand = new CreateCommand(task1, invoker);
        invoker.SetCommand(createCommand);
        invoker.ExecuteCommand();

        Command editCommand = new EditCommand(task1, invoker);
        invoker.SetCommand(editCommand);
        invoker.ExecuteCommand();

        Command deleteCommand = new DeleteCommand(task1, invoker);
        invoker.SetCommand(deleteCommand);
        invoker.ExecuteCommand();
        history.ListHistory();

        Command undoCommand = new UndoCommand(task1, invoker);
        invoker.SetCommand(undoCommand);
        invoker.ExecuteCommand();
        history.ListHistory();

        Command createCommand2 = new CreateCommand(task2, invoker);
        invoker.SetCommand(createCommand2);
        invoker.ExecuteCommand();

        Command editCommand2 = new EditCommand(task2, invoker);
        invoker.SetCommand(editCommand2);
        invoker.ExecuteCommand();

        Command completeCommand = new CompleteCommand(task2, invoker);  
        invoker.SetCommand(completeCommand);
        invoker.ExecuteCommand();
        history.ListHistory();

        Command undoCommand2 = new UndoCommand(task2, invoker);
        invoker.SetCommand(undoCommand2);
        invoker.ExecuteCommand();
        history.ListHistory();

        Console.ReadLine();
    }
}