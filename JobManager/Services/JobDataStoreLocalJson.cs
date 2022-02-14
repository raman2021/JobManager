using JobManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class JobDataStoreLocalJson : IJobDataStore<Job>
    {
        public Task AddJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Task<Job> GetJob(int jobId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            var jobs = new List<Job>()
           {
               new Job {Id = 1, Name = "Job A Local Json File", Description = "This is job a." },
               new Job {Id = 2, Name = "Job B Local Json File", Description = "This is job b." },
               new Job {Id = 3, Name = "Job C Local Json File", Description = "This is job c." },
               new Job {Id = 4, Name = "Job D Local Json File", Description = "This is job d." }
           };
            return jobs;
            //throw new NotImplementedException();
        }

        public Task UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
