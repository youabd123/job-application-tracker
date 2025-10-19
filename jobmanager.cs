using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class JobManager
    {
        private readonly List<JobApplication> applications = new List<JobApplication>();

        public void AddJob(JobApplication application)
        {
            applications.Add(application);
            Console.WriteLine("Ansökan tillagd.");
        }

        public void ShowAll()
        {
            if (applications.Count == 0)
            {
                Console.WriteLine("Inga ansökningar ännu.");
                return;
            }

            Console.WriteLine("--- Alla ansökningar ---");
            foreach (var app in applications)
            {
                Console.WriteLine(app.GetSummary());
            }
        }

        public void UpdateStatus(string companyName, string newStatus)

        {
            var job = FindByCompany(companyName);
            if (job == null)
            {
                Console.WriteLine("Kunde inte hitta företaget.");
                return;
            }

            job.Status = newStatus;
            Console.WriteLine("Status uppdaterad.");
        }

        public void RemoveJob(string companyName)
        {
            var job = FindByCompany(companyName);
            if (job == null)
            {
                Console.WriteLine("Kunde inte hitta företaget.");
                return;
            }

            applications.Remove(job);
            Console.WriteLine("Ansökan borttagen.");
        }

        private JobApplication FindByCompany(string companyName)
        {
            foreach (var job in applications)
            {
                if (string.Equals(job.CompanyName, companyName, StringComparison.OrdinalIgnoreCase))
                    return job;
            }
            return null; // ok för referenstyper
        }
    }
}
