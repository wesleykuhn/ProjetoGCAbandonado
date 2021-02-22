using System;

namespace GC.Library.Objects
{
    internal class Announce
    {
        internal string Body { get; }

        public Announce(string body)
        {
            this.Body = body;
        }
    }
}
