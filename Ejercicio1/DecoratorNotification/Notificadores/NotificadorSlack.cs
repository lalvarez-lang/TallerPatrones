using DecoratorNotification.Entities;
using DecoratorNotification.Interfaces;
using DecoratorNotification.Utils;

namespace DecoratorNotification.Notificadores
{
    public class NotificadorSlack : NotificadorBase
    {
        public NotificadorSlack(INotificador notificador) : base(notificador)
        {
        }

        public override void Enviar(string mensaje, Cliente cliente)
        {
            Console.WriteLine($"Enviando Slack a {cliente.NickName}: {mensaje}");
            base.Enviar(mensaje, cliente);
        }

    }
}