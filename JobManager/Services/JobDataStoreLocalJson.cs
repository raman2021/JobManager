﻿using JobManager.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class JobDataStoreLocalJson : IJobDataStore<Job>
    {
        public static string FilePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, "Jobs.json");
            }
        }
        public async Task AddJob(Job job)
        {
            var jobs = ReadFile();
            jobs.Add(job);
            WriteFile(jobs);
            //throw new NotImplementedException();
        }

        public async Task DeleteJob(Job job)
        {
            var jobs = ReadFile();
            var remove = jobs.Find(p => p.Id == job.Id);
            jobs.Remove(remove);
            //throw new NotImplementedException();
        }

        public async Task<Job> GetJob(int jobId)
        {
            var jobs = ReadFile();
            var job = jobs.Find(p => p.Id == jobId);
            return job;
            //throw new NotImplementedException();
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            var jobs = ReadFile();
            return jobs;
          /* var jobs = new List<Job>()
           {
               new Job {Id = 1, Name = "Job A Local Json File", Description = "This is job a." },
               new Job {Id = 2, Name = "Job B Local Json File", Description = "This is job b." },
               new Job {Id = 3, Name = "Job C Local Json File", Description = "This is job c." },
               new Job {Id = 4, Name = "Job D Local Json File", Description = "This is job d." }
           };
            return jobs; */
            //throw new NotImplementedException();
        }

        public async Task UpdateJob(Job job)
        {
            var jobs = ReadFile();
            jobs[jobs.FindIndex(p => p.Id == job.Id)] = job;
            WriteFile(jobs);
            //throw new NotImplementedException();
        }

       private void WriteFile (List<Job> jobs)
        {
            var jsonString = JsonConvert.SerializeObject(jobs);
            File.WriteAllText(FilePath, jsonString);
        } 

        private List<Job> ReadFile()
        {
            if (File.Exists(FilePath))
            {
                var jsonString = File.ReadAllText(FilePath);
                var jobs = JsonConvert.DeserializeObject<List<Job>>(jsonString);
                return jobs;
            }
            else
            {
                var jobs = GetDefaultJobs();
                WriteFile(jobs);
                return jobs;
            }

        }

        private List<Job> GetDefaultJobs()
        {
            var jobs = new List<Job>()
           {
               new Job {Id = 1, Name = "Job A Local Json File", Description = "This is job a." },
               new Job {Id = 2, Name = "Job B Local Json File", Description = "This is job b." },
               new Job {Id = 3, Name = "Job C Local Json File", Description = "This is job c." },
               new Job {Id = 4, Name = "Job D Local Json File", Description = "This is job d." }
           };
            return jobs;
        }

    }
}
