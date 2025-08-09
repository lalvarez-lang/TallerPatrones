using DecoratorNotification.Interfaces;
using DecoratorNotification.Entities;
using DecoratorNotification.Utils;

namespace DecoratorNotification.Notificadores
{
    public class NotificadorWhatsApp : NotificadorBase
    {
        public NotificadorWhatsApp(INotificador notificador) : base(notificador)
        {
        }

        public override void Enviar(string mensaje, Cliente cliente)
        {
            Console.WriteLine($"Enviando WhatsApp a {cliente.WhatsApp}: {mensaje}");
            base.Enviar(mensaje, cliente);
        }

    }
}