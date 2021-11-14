using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Logic.ViewModels
{
    public class WorkerViewModel
    {
        [DisplayName("Номер для поиска")]
        public int Id { get; set; }
        [DisplayName("ФИО работника")]
        public string WorkerFIO { get; set; }

    }
}
