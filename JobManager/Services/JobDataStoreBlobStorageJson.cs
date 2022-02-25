using JobManager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class JobDataStoreBlobStorageJson : IJobDataStore<Job>
    {
       //https;AccountName=isp1004students2;AccountKey=SIgAofMWnbAOWa0rUyL96/VBKTgnhWipVm1aMCB0RvdFwokcUSLrKL1pYVMjAP6bcL0W4fHsegGD+AStb4GGag==;EndpointSuffix=core.windows.net
       public async Task AddJob(Job job)
        {
            throw new NotImplementedException();
        } 

       
        
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
