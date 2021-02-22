namespace GC.Library.Relations
{
    internal class Id_Double
    {
        internal int Id { get; set; }
        internal double Double { get; set; }

        public Id_Double(int id)
        {
            this.Id = id;
            this.Double = 0;
        }

        public Id_Double(int id, double counter)
        {
            this.Id = id;
            this.Double = counter;
        }        
    }
}
