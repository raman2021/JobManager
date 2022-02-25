using JobManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class JobDataStoreBlobStorageJson : IJobDataStore<Job>
    {
        public async Task AddJob(Job job)
        {
            throw new NotImplementedException();
        }

       /* public Task DeleteJob(Job job)
        {
            throw new NotImplementedException();
        } 

        public async Task<Job> GetJob(Job job)
        {
            throw new NotImplementedException();
        }
       */
        public async Task<Job> GetJob(int jobId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> GetJobs()
        {
            throw new NotImplementedException();
        }
        public async Task UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }
    }
}
