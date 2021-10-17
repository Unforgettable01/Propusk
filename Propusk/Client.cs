using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propusk
{
    public class Client
    {
        public int Id { get; } // ключ клиента
        //public int WorkerId { get; set; }
        public Client(int Id/*, int WorkerId*/)
        {
            this.Id = Id;
            //this.WorkerId = WorkerId;
        }
        //public void Start (StringBuilder textInfo)
        //{
        //    textInfo.AppendLine("Сотрудник № - " + Id + " прошел контроль");
        //}
    }
}
