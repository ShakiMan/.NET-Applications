using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab11.ViewModels;

namespace Lab11.DataContext
{
    public interface IDataContext
    {
        List<WorkerViewModel> GetWorkers();
        WorkerViewModel GetWorker(int id);
        void AddWorker(WorkerViewModel worker);
        void RemoveWorker(int id);
        void UpdateWorker(WorkerViewModel worker);
    }
}
