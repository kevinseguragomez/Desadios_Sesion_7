using System;

interface INotificable
{
    void Notifica();
}

class NotificacionEmail : INotificable
{
    public string direccionCorreo = "";

    public void Notifica()
    {
        Console.WriteLine("Enviando Email a: " + direccionCorreo);
    }
}

class NotificacionWhatsapp : INotificable
{
    public string numeroTelefono = "";

    public void Notifica()
    {
        Console.WriteLine("Enviando WhatsApp a: " + numeroTelefono);
    }
}

class NotificacionSMS : INotificable
{
    public string numeroTelefono = "";

    public void Notifica()
    {
        Console.WriteLine("Enviando SMS a: " + numeroTelefono);
    }
}

class Program
{
    static void Main()
    {
        NotificacionEmail email = new NotificacionEmail();
        email.direccionCorreo = "ksegurag@miumg.edu.gt";

        NotificacionWhatsapp whatsapp = new NotificacionWhatsapp();
        whatsapp.numeroTelefono = "+502 3394-6582";

        NotificacionSMS sms = new NotificacionSMS();
        sms.numeroTelefono = "+502 3394-6582";

        email.Notifica();
        whatsapp.Notifica();
        sms.Notifica();
    }
}
