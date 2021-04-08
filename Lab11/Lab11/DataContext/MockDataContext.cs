using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab11.ViewModels;

namespace Lab11.DataContext
{
    public class MockDataContext : IDataContext
    {
        List<WorkerViewModel> workers = new List<WorkerViewModel>()
        {
            new WorkerViewModel(0, "asd@oasd.pl", "Smksl", "56-343", Category.Worker)
        };
        

        public void AddWorker(WorkerViewModel worker)
        {
            int nextNumber;
            if (workers.Count == 0)
            {
                nextNumber = 0;
            }
            else
            {
                nextNumber = workers.Max(s => s.Id) + 1;
            }
            worker.Id = nextNumber;
            workers.Add(worker);
        }

        public List<WorkerViewModel> GetWorkers()
        {
            return workers;
        }

        public WorkerViewModel GetWorker(int id)
        {
            return workers.FirstOrDefault(s => s.Id == id);
        }

        public void RemoveWorker(int id)
        {
            WorkerViewModel workerToRemove = workers.FirstOrDefault(s => s.Id == id);
            if (workerToRemove != null)
                workers.Remove(workerToRemove);
        }

        public void UpdateWorker(WorkerViewModel worker)
        {
            WorkerViewModel studToUpdate = workers.FirstOrDefault(s => s.Id == worker.Id);
            workers = workers.Select(s => (s.Id == worker.Id) ? worker : s).ToList();
        }
    }
}
