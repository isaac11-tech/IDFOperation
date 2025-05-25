using System;
using ConsoleApp1.message;

namespace ConsoleApp1.NewFolder
{
    public class Intelligence
    {
        private List<Message> Messages {  get; }

        Intelligence()
        {
            Messages = new List<Message>();
        }

        public void AddMessage(Message report)
        {
            Messages.Add(report);
        }
        public void RemoveMessage(Message report)
        {
            Messages.Remove(report);
        }









    }
}
