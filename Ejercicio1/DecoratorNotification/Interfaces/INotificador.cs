using DecoratorNotification.Entities;

namespace DecoratorNotification.Interfaces
{
    public interface INotificador
    {
        void Enviar(string mensaje, Cliente cliente);
    }
}