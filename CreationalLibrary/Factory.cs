using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalLibrary
{
    // Bildirim göndereceğimiz class
    public class Admin
    {
        public string? Email { get; set; }
        public string? GSM { get; set; }
    }

    // Gerçek bildirim classlarının türetildiği arayüz
    public interface INotify
    {
        string SendNotification(Admin admin);
    }

    // Email için oluşturulan gerçek işlemin yağıldığı notify class
    public class EmailNotify : INotify
    {
        public string SendNotification(Admin admin)
        {
            return $"{admin.Email} adresine mail gönderildi"; 
        }
    }

    // Sms için oluşturulan gerçek işlemin yağıldığı notify class
    public class SMSNotify : INotify
    {
        public string SendNotification(Admin admin)
        {
            return $"{admin.GSM} numarasına sms gönderildi";
        }
    }

    // clientin email veya sms gönderme ihtiyacını karşılayacak factory class ı 
    public class NotifyFactory
    {
        public INotify CreateNotify(NotifyType notifyType)
        {
            switch (notifyType)
            {
                case NotifyType.Email:
                    return new EmailNotify();
                case NotifyType.SMS:
                    return new SMSNotify();
                default:
                    return null;
            }
        }
    }

    // Bildirim tipimizin factory de gönderilirken clientin isteyebileceği tipler tanımlanmıştır.
    public enum NotifyType
    {
        Email,
        SMS,
    }
}
