using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab11.DataContext;
using Lab11.ViewModels;

namespace Lab11.Controllers
{
    public class WorkerController : Controller
    {
        // remeber the context for an action
        private IDataContext _dataContext;

        // injection of IDataContext
        public WorkerController(IDataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        // GET: WorkerController
        public ActionResult Index()
        {
            return View(_dataContext.GetWorkers());
        }

        //[Route("newDetails/{id}", Name ="newDetailsRoute")]
        // GET: WorkerController/Details/5
        public ActionResult Details(int id)
        {
            return View(_dataContext.GetWorker(id));
        }

        // GET: WorkerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkerViewModel worker)
        {
            try
            {
                if (ModelState.IsValid)                // added
                    _dataContext.AddWorker(worker);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_dataContext.GetWorker(id));
        }

        // POST: WorkerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorkerViewModel worker)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    worker.Id = id; // added
                    _dataContext.UpdateWorker(worker); //added
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WorkerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_dataContext.GetWorker(id));
        }

        // POST: WorkerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _dataContext.RemoveWorker(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
