using Database.Models;
using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Implements
{
    public class WorkerStorage : IWorkerStorage
    {
        public List<WorkerViewModel> GetFullList()
        {
            using (var context = new DatabaseContext())
            {
                return context.Workers
                .Select(CreateModel).ToList();
            }
        }

        public List<WorkerViewModel> GetFilteredList(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DatabaseContext())
            {
                return context.Workers
                    .Where(rec => rec.WorkerFIO.Contains(model.WorkerFIO) || (rec.WorkerFIO.Equals(model.WorkerFIO)))
                    .Select(CreateModel).ToList();
            }
        }

        public WorkerViewModel GetElement(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DatabaseContext())
            {
                var worker = context.Workers
                    .FirstOrDefault(rec => rec.WorkerFIO.Equals(model.WorkerFIO) || rec.id == model.Id);
                return worker != null ? CreateModel(worker) : null;
            }
        }

        public void Insert(WorkerBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                context.Workers.Add(CreateModel(model, new Worker()));
                context.SaveChanges();
            }
        }

        public void Delete(WorkerBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                Worker element = context.Workers.FirstOrDefault(rec => rec.id == model.Id);
                if (element != null)
                {
                    context.Workers.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Работник не найден");
                }
            }
        }

        private Worker CreateModel(WorkerBindingModel model, Worker worker)
        {
            worker.WorkerFIO = model.WorkerFIO;
            return worker;
        }

        private WorkerViewModel CreateModel(Worker worker)
        {
            return new WorkerViewModel
            {
                Id = worker.id,
                WorkerFIO = worker.WorkerFIO
            };
        }
    }
}
