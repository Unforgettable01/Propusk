using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Logics
{
    public class WorkerLogic
    {
        private readonly IWorkerStorage _workerStorage;

        public WorkerLogic(IWorkerStorage workerStorage)
        {
            _workerStorage = workerStorage;
        }

        public List<WorkerViewModel> Read(WorkerBindingModel model)
        {
            if (model == null)
            {
                return _workerStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<WorkerViewModel> { _workerStorage.GetElement(model) };
            }
            return _workerStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(WorkerBindingModel model)
        {
            var element = _workerStorage.GetElement(new WorkerBindingModel
            {
                WorkerFIO = model.WorkerFIO
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть работник с таким логином");
            }
            else
            {
                _workerStorage.Insert(model);
            }
        }

        public void Delete(WorkerBindingModel model)
        {
            var element = _workerStorage.GetElement(new WorkerBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Работник не найден");
            }
            _workerStorage.Delete(model);
        }
    }
}
