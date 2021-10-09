using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propusk
{
    public class WorkShift
    {
        public int Id { get; } // id рабочей смены
        public int WorkerId { get; } // id сотрудника в смене
        public int VisitorId { get; } // id посетителя 
        public int ShiftTime { get; set; }   // Время смены
        public int BreakTime { get; set; }    // Время перерыва между двумя сотрудниками


        public WorkShift (int id, int workerId, int visitorId, int shiftTime, int breakTime)
        {
            Id = id;
            WorkerId = workerId;
            VisitorId = visitorId;
            ShiftTime = shiftTime;
            BreakTime = breakTime;
        }

        public int Start(int allocatedTime, StringBuilder textInfo)
        {
            //textInfo.Append("Смена " + Id + " Сотрудник -  " + WorkerId + " начал свою работу)");

            //return 0;
            //if (ShiftTime == 24)
            //{
            //    textInfo.AppendLine(", отработал " + RemainingTime + " и завершил работу");
            //    return RemainingTime;
            //}
            //else
            //{
            //    RemainingTime -= allocatedTime;
            //    textInfo.AppendLine(", отработал все выделенное время (" + allocatedTime + ") и был прерван (" + RemainingTime + ")");
              return 0;
            //}
        }
    }
}
