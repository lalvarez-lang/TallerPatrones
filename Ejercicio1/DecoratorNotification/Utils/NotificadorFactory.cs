using DecoratorNotification.Notificadores;
using DecoratorNotification.Interfaces;

namespace DecoratorNotification.Utils
{
    public class NotificadorFactory
    {
        public static INotificador CrearDesdePreferencias(List<string> canales)
        {
            INotificador notificador = null;

            foreach (var canal in canales)
            {
                switch (canal.ToLower())
                {
                    case "correo":
                        notificador = new NotificadorCorreo(notificador);
                        break;
                    case "sms":
                        notificador = new NotificadorSMS(notificador);
                        break;
                    case "whatsapp":
                        notificador = new NotificadorWhatsApp(notificador);
                        break;
                        // Se pueden agregar más canales sin modificar lo existente
                }
            }

            return notificador;
        }
    }
}