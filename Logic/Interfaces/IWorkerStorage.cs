using Logic.BindingModels;
using Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces
{
    public interface IWorkerStorage
    {
        List<WorkerViewModel> GetFilteredList(WorkerBindingModel model);
        List<WorkerViewModel> GetFullList();
        WorkerViewModel GetElement(WorkerBindingModel model);
        void Insert(WorkerBindingModel model);
        void Delete(WorkerBindingModel model);
    }
}
