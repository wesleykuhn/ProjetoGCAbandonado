using System;

namespace GC.Library.Objects
{
    internal class AdminMessage
    {
        internal int Id { get; }
        internal DateTime DeliveredIn { get; }
        internal DateTime ReadIn { get; set; }
        internal string Subject { get; }
        internal string Body { get; }
        internal byte Color { get; }

        public AdminMessage(int id, DateTime delivered_in, DateTime read_in, string subject, string body, byte color)
        {
            this.Id = id;
            this.DeliveredIn = delivered_in;
            this.ReadIn = read_in;
            this.Subject = subject;
            this.Body = body;
            this.Color = color;
        }
    }
}
