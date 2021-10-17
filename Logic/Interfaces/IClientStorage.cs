using Logic.BindingModels;
using Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces
{
    public interface IClientStorage
    {
        List<ClientViewModel> GetFilteredList(ClientBindingModel model);
        List<ClientViewModel> GetFullList();
        ClientViewModel GetElement(ClientBindingModel model);
        //void Insert(ClientBindingModel model);
        //void Delete(ClientBindingModel model);
    }
}
