// Interfaz para componentes del sistema de archivos
namespace FileSystemCompositeExample.Interfaces
{
    public interface IFileSystemComponent
    {
        string Name { get; }
        long Size { get; }
        void Print(int indent);
        void Rename(string newName);
        void Delete();
    }
}