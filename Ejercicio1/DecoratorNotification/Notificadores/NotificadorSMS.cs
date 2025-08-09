using DecoratorNotification.Interfaces;
using DecoratorNotification.Entities;
using DecoratorNotification.Utils;

namespace DecoratorNotification.Notificadores
{
    public class NotificadorSMS : NotificadorBase
    {
        public NotificadorSMS(INotificador notificador) : base(notificador)
        {
        }

        public override void Enviar(string mensaje, Cliente cliente)
        {
            Console.WriteLine($"Enviando SMS a {cliente.Telefono}: {mensaje}");
            base.Enviar(mensaje, cliente);
        }

    }
}