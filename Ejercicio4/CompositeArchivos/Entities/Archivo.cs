using CompositeArchivos.Interfaces;

namespace CompositeArchivos.Entities
{
     public class Archivo(string name, long size) : IFileSystemComponent
    {
        public string Name { get; private set; } = name;
        public long Size { get; private set; } = size;

        public void Print(int indent)
        {
            Console.WriteLine($"{new string(' ', indent)}- File: {Name} (Size: {Size} bytes)");
        }

        public void Rename(string newName)
        {
            Name = newName;
        }

        public void Delete()
        {
            Console.WriteLine($"File {Name} deleted.");
        }
    }
}