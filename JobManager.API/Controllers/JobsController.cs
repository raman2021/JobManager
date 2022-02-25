using JobManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManager.API.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class JobsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Job> Get()
        {
            return GetDefaultJobs();
        }

        private List<Job> GetDefaultJobs()
        {
            var jobs = new List<Job>()
           {
               new Job {Id = 1, Name = "Job A API", Description = "This is job a." },
               new Job {Id = 2, Name = "Job B API", Description = "This is job b." },
               new Job {Id = 3, Name = "Job C API", Description = "This is job c." },
               new Job {Id = 4, Name = "Job D API", Description = "This is job d." }
           };
            return jobs;
        }

        /* GET: JobsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: JobsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
