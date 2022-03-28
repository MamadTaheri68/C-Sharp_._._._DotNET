using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.TestConstraints
{
    public interface IMessage
    {
        void SendMessage();
    }
    public class Sms : IMessage
    {
        public void SendMessage()
        {
             
        }
    }
    public class Email : IMessage
    {
        public void SendMessage()
        {
             
        }
    }
    public class MessageSender<T,T2> //where T : IMessage
    {
        public void SendAllMessages(List<T> messages)
        {
            //foreach (var item in messages)
            //{
            //    item.SendMessage();
            //}
        }
    }
    public class Message2<T,T2>: MessageSender<T,T2>
    {

    }
    public class Message3<T>: MessageSender<T,string>
    {

    }
    public class Message4: MessageSender<int, string>
    {

    }
    class TestConstraint
    {

    }

    public class MessageSenderTest
    {
        public MessageSenderTest()
        {
        //    MessageSender<Email> imsg = new MessageSender<Email>();
        //    imsg.SendAllMessages(new List<Email>());
        //}
    }
}
