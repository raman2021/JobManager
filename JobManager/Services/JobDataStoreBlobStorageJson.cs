using Azure.Storage.Blobs;
using JobManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class JobDataStoreBlobStorageJson : IJobDataStore<Job>
    {
        private readonly BlobServiceClient service = new BlobServiceClient(ConnectionString);
        private static string ConnectionString => "connectionstringhere";
        private static string Container => "data";
        private static string Filename => "Jobs.json";

        public async Task WriteFile(List<Job> jobs)
        {
            var jsonString = JsonConvert.SerializeObject(jobs);
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(jsonString);
            writer.Flush();
            stream.Position = 0;
            BlobClient blob = service.GetBlobContainerClient(Container).GetBlobClient(Filename);
            await blob.UploadAsync(stream);


        }
        public async Task<List<Job>> ReadFile()
        {
            BlobClient blob = service.GetBlobContainerClient(Container).GetBlobClient(Filename);

            if (blob.Exists())
            {
                var stream = new MemoryStream();
                await blob.DownloadToAsync(stream);

                stream.Position = 0;
                var jsonString = new StreamReader(stream).ReadToEnd();
                var jobs = JsonConvert.DeserializeObject<List<Job>>(jsonString);
                return jobs;
                 
            }
            else
            {
                var defaultJobs = GetDefaultJobs();
                await WriteFile(defaultJobs);
                return defaultJobs;
            }
        }

        private List<Job> GetDefaultJobs()
        {
            var jobs = new List<Job>()
           {
               new Job {Id = 1, Name = "Job A Azure blob File", Description = "This is job a." },
               new Job {Id = 2, Name = "Job B Azure blob File", Description = "This is job b." },
               new Job {Id = 3, Name = "Job C Azure blob File", Description = "This is job c." },
               new Job {Id = 4, Name = "Job D Azure blob File", Description = "This is job d." }
           };
            return jobs;
        }




        //https;AccountName=isp1004students2;AccountKey=SIgAofMWnbAOWa0rUyL96/VBKTgnhWipVm1aMCB0RvdFwokcUSLrKL1pYVMjAP6bcL0W4fHsegGD+AStb4GGag==;EndpointSuffix=core.windows.net
        public async Task AddJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Task DeleteJob(Job job)
        {
            throw new NotImplementedException();
        }

        public async Task<Job> GetJob(int jobId)
        {
            throw new NotImplementedException();
        } 

        public async Task<List<Job>> GetJobs()
        {
            var jobs = await ReadFile();
            return jobs;
        }
        public async Task UpdateJob(Job job)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Job>> IJobDataStore<Job>.GetJobs()
        {
            throw new NotImplementedException();
        }
    }
}
