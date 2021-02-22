namespace GC.Library.Objects.SubObjects.Request
{
    public class Request_Jobs
    {
        public int Id_Job { get; set; }
        public double Price { get; set; }

        public Request_Jobs() { }

        public Request_Jobs(int id_job, double price)
        {
            this.Id_Job = id_job;
            this.Price = price;
        }
    }
}
