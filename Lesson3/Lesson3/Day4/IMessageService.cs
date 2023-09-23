using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Day4
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMesaage();
        void DeleteMessage();

    }
    public interface IPayments
    {
        void MakePayment(float amount);
    }
    internal class WhatsApp : IMessageService
    {
        public void MakePayment(float amount)
        {
            Console.WriteLine($"amount:{amount}");
        }
        public void DeleteMessage()
        {
            Console.WriteLine("Message Deleted");
        }
        public void ReceiveMesaage()
        {
            Console.WriteLine("Method Not Implemented");

        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
      
    }
    public class MesssageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new WhatsApp();
            messageService.SendMessage("Hello");
            messageService.ReceiveMesaage();

        }

    }
}