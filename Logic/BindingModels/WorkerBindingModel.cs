﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.BindingModels
{
    public class WorkerBindingModel
    {
        public int? Id { get; set; }
        public string WorkerFIO { get; set; }
        public int WorkingTime { get; set; }
        public int PauseTime { get; set; }
    }
}