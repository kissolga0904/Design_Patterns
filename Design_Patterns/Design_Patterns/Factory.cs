using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    //Alap noti ami notifikalja a usert
    //ennek a factorynek ha megadom hogy milyen channel, akkor 
    public interface Notification
    {
        void notifyUser();
    }

    public class PushNotification : Notification
    {
        public void notifyUser()
        {
            Console.WriteLine("Sending push notification");
        }
    }

    public class SMSNotification : Notification
    {
        public void notifyUser()
        {
            Console.WriteLine("Sending SMS notification");
        }
    }

    public class NotificationFactory
    {
        public Notification createNotification(string channel)
        {
            if(channel == null || channel == string.Empty)
            {
                return null;
            }
            switch (channel)
            {
                case "SMS":
                    return new SMSNotification();
                case "PUSH":
                    return new PushNotification();
                default:
                    Console.WriteLine("Unknown channel");
                    return null;
            }
        }
    }
}
