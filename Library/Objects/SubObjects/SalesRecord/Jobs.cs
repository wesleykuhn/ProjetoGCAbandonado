namespace GC.Library.Objects.SubObjects.SalesRecord
{
    internal class Jobs
    {
        internal int Id_Job { get; set; }
        internal int SalesCounter { get; set; }
        internal double SalesAmount { get; set; }

        internal Jobs(int id_job)
        {
            this.Id_Job = id_job;
            this.SalesCounter = 0;
            this.SalesAmount = 0;
        }

        internal string GetJobName()
        {
            if (this.Id_Job == -1)
            {
                return null;
            }
            return Job.GetJobName(this.Id_Job);
        }
    }
}
