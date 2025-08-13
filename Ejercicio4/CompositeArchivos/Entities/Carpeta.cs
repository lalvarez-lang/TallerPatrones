using CompositeArchivos.Interfaces;

namespace CompositeArchivos.Entities
{
    public class Carpeta(string name) : IFileSystemComponent
    {
        public string Name { get; private set; } = name;
        private List<IFileSystemComponent> _children = new List<IFileSystemComponent>();

        public long Size
        {
            get
            {
                long totalSize = 0;
                foreach (var child in _children)
                {
                    totalSize += child.Size;
                }
                return totalSize;
            }
        }

        public void Add(IFileSystemComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            _children.Remove(component);
        }

        public void Print(int indent)
        {
            Console.WriteLine($"{new string(' ', indent)}+ Folder: {Name} (Total Size: {Size} bytes)");
            foreach (var child in _children)
            {
                child.Print(indent + 2);
            }
        }

        public void Rename(string newName)
        {
            Name = newName;
        }

        public void Delete()
        {
            Console.WriteLine($"Folder {Name} deleted.");
            foreach (var child in _children)
            {
                child.Delete();
            }
        }
    }
}