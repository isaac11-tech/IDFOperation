using System;

namespace redzone.bluezone
{
    public class Intelligence
    {
        public List<Message> Reports {  get; }

        public Intelligence()
        {
            Reports = new List<Message>();
        }

        public void AddMessage(Message report)
        {
            Reports.Add(report);
        }
        public void RemoveMessage(Message report)
        {
            Reports.Remove(report);
        }









    }
}
