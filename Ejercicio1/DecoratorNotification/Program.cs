using DecoratorNotification.Interfaces;
using DecoratorNotification.Entities;
using DecoratorNotification.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        #region databaseObjects

        var cliente = new Cliente
        {
            Nombre = "Esneider",
            Email = "esneider@ejemplo.com",
            NickName = "3sneider",
            Telefono = "3001234567",
            WhatsApp = "3001234567"
        };

        var canales = new List<string> { "whatsapp", "sms", "slack" };

        #endregion

        INotificador notificador = NotificadorFactory.CrearDesdePreferencias(canales);

        notificador.Enviar("Tu pedido ha sido procesado con éxito.", cliente);

        Console.ReadKey();
    }
}