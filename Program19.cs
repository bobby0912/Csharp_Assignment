//**Real - World Observer Pattern for Notifications**

//Implement an `INotificationObserver` interface where `EmailNotifier` and `SMSNotifier`
//listen for notifications. When a new message arrives, all observers should receive an update.

using c__Assignment;
using System;
using System.Collections.Generic;

namespace c__Assignment
{
    interface INotificationObserver
    {
        void Update(string message);
    }

    class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    class NotificationService
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

    class Program19
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();

            INotificationObserver emailNotifier = new EmailNotifier();
            INotificationObserver smsNotifier = new SMSNotifier();

            notificationService.Subscribe(emailNotifier);
            notificationService.Subscribe(smsNotifier);

            notificationService.Notify("New message received!");

            notificationService.Unsubscribe(emailNotifier);

            notificationService.Notify("Another message received!");
        }
    }
}



