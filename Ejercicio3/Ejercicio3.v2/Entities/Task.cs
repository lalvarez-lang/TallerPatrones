namespace Ejercicio3.Entities
{
    public class Task
    {
        public long id { get; set; }
        public string name { get; set; }

        public Task(long id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return $"Task ID: {id}, Name: {name}";
        }

        public void Create()
        {
            Console.WriteLine($"Task '{name}' with ID {id} created successfully.");
        }

        public void Edit()
        {
            Console.WriteLine($"Task '{name}' with ID {id} edited successfully.");
        }

        public void Delete()
        {
            Console.WriteLine($"Task '{name}' with ID {id} deleted successfully.");
        }

        public void Complete()
        {
            Console.WriteLine($"Task '{name}' with ID {id} completed successfully.");
        }
    }
}
