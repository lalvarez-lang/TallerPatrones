# TallerPatrones


#Ejercicio4

@startuml
interface IFileSystemComponent {
    +Name: string
    +Size: long
    +Print(indent: int): void
    +Rename(newName: string): void
    +Delete(): void
}

class Archivo implements IFileSystemComponent {
    +Name: string
    +Size: long
    +Print(indent: int): void
    +Rename(newName: string): void
    +Delete(): void
}

class Carpeta implements IFileSystemComponent {
    +Name: string
    +Size: long
    +Print(indent: int): void
    +Rename(newName: string): void
    +Delete(): void
    +Add(component: IFileSystemComponent): void
    +Remove(component: IFileSystemComponent): void
}

@enduml