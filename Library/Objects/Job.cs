using System.Collections.Generic;

namespace GC.Library.Objects
{
    internal class Job
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal double Price { get; set; }

        public Job(int id, string name, string description, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

        internal bool IsEqualTo(Job job)
        {
            if (job.Name == this.Name && job.Description == this.Description && job.Price == this.Price) return true;
            else return false;
        }

        /// <summary>
        /// Returns the Job's ID by making a search by job's name. It will return -1 if there's no job found with that name.
        /// </summary>
        /// <param name="The name of the job to be found."></param>
        /// <returns></returns>
        internal static int GetJobId(string name)
        {
            int jobId = -1;

            if (name == "Excluído") return jobId;

            int index = GlobalVariables.Jobs.FindIndex(x => x.Name == name);
            return GlobalVariables.Jobs[index].Id;
        }

        internal static string GetJobName(int id)
        {
            string jobName = "Excluído";

            if (id == -1) return jobName;

            int index = GlobalVariables.Jobs.FindIndex(x => x.Id == id);
            return GlobalVariables.Jobs[index].Name;
        }

        internal static bool AListContains(List<Job> jobs, string jobName)
        {
            foreach (Job item in jobs)
            {
                if (item.Name == jobName) return true;
            }

            return false;
        }

        internal static Job CloneJob(string name)
        {
            if (name == null || name == "") return null;

            int index = GlobalVariables.Jobs.FindIndex(x => x.Name == name);

            if (index < 0) return null;
            else return GlobalVariables.Jobs[index];
        }

        internal static Job CloneJob(int id)
        {
            if (id == -1) return null;

            int index = GlobalVariables.Jobs.FindIndex(x => x.Id == id);
            if (index < 0) return null;

            else return GlobalVariables.Jobs[index];
        }
    }
}
