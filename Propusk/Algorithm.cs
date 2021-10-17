using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Propusk
{
    public class Algorithm
    {
        public DrawInfo DrawInfo { get; private set; }
        private Queue<Worker> workers { get; set; }  // очередь работников 
        private Queue<Client> clients { get; set; }  // очередь клиентов
        public int ShiftTime { get; set; }   // Время смены  -  выделенное время  на смену 
        public int TimeOnClient = 3;
        public  int workersCount { get; set; }
        public int clientsCount { get; set; }
        public Algorithm(int ShiftTime, int workersCount, int clientsCount)
        {
            this.ShiftTime = ShiftTime; // получаем время смены  -  24 часа, за это время несколько работников обрабатывают очередь клиентов
            this.clientsCount = clientsCount;
            this.workersCount = workersCount;
        }
        public StringBuilder Shedule()
        {
            StringBuilder textInfo = new StringBuilder();
            // DrawInfo = new DrawInfo();
            Init(textInfo);
            int workersCountForError = workers.Count;
            while (workers.Count != 0)
            {
                if (clients.Count==0)
                {
                    textInfo.AppendLine("Все пассажиры успешно прошли");
                    break;
                }
                Worker actualWorker = workers.Dequeue();
                int actualRemainingTime = actualWorker.RemainingTime;
                textInfo.AppendLine("|---------------------------------------------------------------------------------------|");
                textInfo.AppendLine("На пост вышел сотрудник с номером - " + actualWorker.Id);
                textInfo.AppendLine("|---------------------------------------------------------------------------------------|");
                while (actualRemainingTime >= TimeOnClient)
                {
                    if (clients.Count != 0)
                    {
                        actualRemainingTime -= TimeOnClient;
                        Client actualClient = clients.Dequeue();
                        textInfo.AppendLine("Пассажир с номером - " + actualClient.Id + " прошел контроль");
                    }
                    else
                    {
                        //textInfo.AppendLine("Все пассажиры успешно прошли");
                        break;

                    }
                }
            }
            if (workers.Count == 0 && clients.Count >0)
            {
                textInfo.AppendLine("Указанного количества персонала не хватило, чтобы обработать указанное количество пассажиров");
                textInfo.AppendLine("Осталось " + clients.Count + "  пассажиров и для их обслуживания требуется еще минимум - " + clients.Count*TimeOnClient + " секунд");
                textInfo.AppendLine("Для данного количесва пассажиров требуется еще "+ (clients.Count * TimeOnClient)/ workersCountForError + " сотрудников");


                MessageBox.Show("Указанного количества персонала не хватило, чтобы обработать указанное количество пассажиров");

            }
            return textInfo;
        }
        private void Init(StringBuilder textInfo)
        {
            //Random random = new Random();
            workers = new Queue<Worker>();
            clients = new Queue<Client>();

            //int workersCount = random.Next(3, 5);  // количество работников от 3 до 5    
            int actualRemainingTime = ShiftTime / workersCount;
            for (int i = 0; i < workersCount; i++)
            {
                workers.Enqueue(new Worker(i+1, actualRemainingTime));
                textInfo.AppendLine("Была создан работник №  -  " + (i + 1));
            }
            textInfo.AppendLine("Всего на смене " + workersCount + " работников");

            //int clientsCount = random.Next(8, 100);  //  количество клиентов от 3 до 5 
            for (int i = 0; i < clientsCount; i++)
            {
                clients.Enqueue(new Client(i+1));
            }
            textInfo.AppendLine("Всего на смене " + clientsCount + " клиентов");


            textInfo.AppendLine();
            textInfo.AppendLine().AppendLine().AppendLine();

        }
    }
}

