
using System;
using System.Net;
using System.Net.Mail;

class Program
{
    static void Main()
    {
        string toAddress = "gönderilen mail";
        string fromAddress = "gönderen mail";
        string subject = "Test E-postası";
        string body = "Bu bir test e-postasıdır.";

        SmtpClient client = new SmtpClient("smtp.mail.me.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("gönderen_ mail" , "gönderen_ mail_sifre"),
            EnableSsl = true,
        };

        MailMessage mail = new MailMessage(fromAddress, toAddress, subject, body);

        try
        {
            client.Send(mail);
            Console.WriteLine("E-posta başarıyla gönderildi.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("E-posta gönderimi sırasında hata oluştu: " + ex.Message);
        }
    }
}
