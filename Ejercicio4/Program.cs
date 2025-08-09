
using FileSystemCompositeExample.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear archivos
        var Archivo1 = new Archivo("File1.txt", 100);
        var Archivo2 = new Archivo("File2.txt", 200);
        var Archivo3 = new Archivo("File3.txt", 300);

        // Crear carpetas
        var Carpeta1 = new Carpeta("Folder1");
        var Carpeta2 = new Carpeta("Folder2");

        // Agregar archivos a carpetas
        Carpeta1.Add(Archivo1);
        Carpeta1.Add(Archivo2);
        Carpeta2.Add(Archivo3);

        // Crear una carpeta principal y agregar subcarpetas
        var rootCarpeta = new Carpeta("RootFolder");
        rootCarpeta.Add(Carpeta1);
        rootCarpeta.Add(Carpeta2);

        // Imprimir la estructura del sistema de archivos
        rootCarpeta.Print(0);

        // Renombrar un archivo
        Archivo1.Rename("RenamedFile1.txt");

        // Imprimir la estructura después del cambio
        Console.WriteLine("Despues Renombar:");
        rootCarpeta.Print(0);

        // Borrar un archivo
        Archivo2.Delete();
        Carpeta1.Remove(Archivo2);

        // Imprimir la estructura después de borrar
        Console.WriteLine("Despues de Borrar Archivo 2:");
        rootCarpeta.Print(0);

        // Borrar una carpeta
        Carpeta2.Delete();
        rootCarpeta.Remove(Carpeta2);

        // Imprimir la estructura después de borrar la carpeta
        Console.WriteLine("Despues de Borrar Folder 2:");
        rootCarpeta.Print(0);
    }
}

