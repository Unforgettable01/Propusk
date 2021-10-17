using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propusk
{
    public class Worker
    {
        public int Id { get; } // ключ работникa
        public int RemainingTime { get; set; }  // оставшееся время


        public Worker(int Id,int RemainingTime)
        {
            this.Id = Id;
            this.RemainingTime = RemainingTime;
        }
        //public int Start(int allocatedTime, StringBuilder textInfo)
        //{
        //    textInfo.AppendLine("Сотрудник № - " + Id + " начал свою работу (оставшееся рабочее время " + RemainingTime + ")");
        //    if (RemainingTime < allocatedTime)
        //    {
        //        return RemainingTime;
        //    }
        //    else
        //    {
        //        RemainingTime -= allocatedTime;
        //        return 0;
        //    }
        //}
    }
}
