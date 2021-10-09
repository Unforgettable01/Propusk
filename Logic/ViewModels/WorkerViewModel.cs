using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Logic.ViewModels
{
    public class WorkerViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО работника")]
        public string WorkerFIO { get; set; }
        [DisplayName("Время на заказ")]
        public int WorkingTime { get; set; }
        [DisplayName("Время на перерыв")]
        public int PauseTime { get; set; }
    }
}
