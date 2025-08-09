using DecoratorNotification.Entities;
using DecoratorNotification.Interfaces;

namespace DecoratorNotification.Utils
{
    public class NotificadorBase : INotificador
    {
        protected INotificador _notificador;
        public NotificadorBase(INotificador notificador)
        {
            _notificador = notificador;
        }

        public virtual void Enviar(string mensaje, Cliente cliente)
        {
            _notificador?.Enviar(mensaje, cliente);
        }

    }
}