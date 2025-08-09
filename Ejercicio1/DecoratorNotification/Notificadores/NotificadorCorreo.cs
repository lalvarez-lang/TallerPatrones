using DecoratorNotification.Interfaces;
using DecoratorNotification.Entities;
using DecoratorNotification.Utils;

namespace DecoratorNotification.Notificadores
{
    public class NotificadorCorreo : NotificadorBase
    {
        public NotificadorCorreo(INotificador notificador) : base(notificador)
        {
        }

        public override void Enviar(string mensaje, Cliente cliente)
        {
            Console.WriteLine($"Enviando correo a {cliente.Email}: {mensaje}");
            base.Enviar(mensaje, cliente);
        }

    }
}