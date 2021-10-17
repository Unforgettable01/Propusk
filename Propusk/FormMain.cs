using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Unity;

namespace Propusk
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private Queue<Worker> workers;  // очередь работников 
        private Queue<Client> clients;  // очередь клиентов 
        private int clientsCount { get; set; }
        private int workersCount { get; set; }
        public int TimeOnClient = 3;
        public int ShiftTime = 240;
        public DrawInfo DrawInfo { get; private set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Clear();
            workersCount = Convert.ToInt32(comboBoxCountWorkers.SelectedItem.ToString());
            clientsCount = Convert.ToInt32(comboBoxCountVisitors.SelectedItem.ToString());
            Shedule();
        }
        private void buttonSaveReport_Click(object sender, EventArgs e)
        {
            string filename = "C:\\Users\\borya\\Downloads\\propusk.txt";
            try
            {
                File.WriteAllText(filename, richTextBoxInfo.Text);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибкa тут: " + ex.Message);
            }
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<WorkersForm>();
            form.ShowDialog();
        }

        private void посетителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ClientsForm>();
            form.ShowDialog();
        }

        public void Shedule()
        {
            //StringBuilder textInfo = new StringBuilder();
            Init();
            int workersCountForError = workers.Count;
            while (workers.Count != 0)
            {
                if (clients.Count == 0)
                {
                    richTextBoxInfo.AppendText("\nВсе пассажиры успешно прошли\n");
                    break;
                }
                Worker actualWorker = workers.Dequeue();
                if (actualWorker.Id != 1)
                {
                    richTextBoxInfo.AppendText("\nПроисходит смена персонала\n");
                    //System.Threading.Thread.Sleep(500);

                }
                int actualRemainingTime = actualWorker.RemainingTime;
                richTextBoxInfo.AppendText("\n|---------------------------------------------------------------------------------------|\n");
                richTextBoxInfo.AppendText("\nНа пост вышел сотрудник с номером - " + actualWorker.Id);
                richTextBoxInfo.AppendText("\n|---------------------------------------------------------------------------------------|\n");
                while (actualRemainingTime >= TimeOnClient)
                {
                    if (clients.Count != 0)
                    {
                        actualRemainingTime -= TimeOnClient;
                        Client actualClient = clients.Dequeue();
                        //System.Threading.Thread.Sleep(500);
                        Draw();
                        richTextBoxInfo.AppendText("\nПассажир с номером - " + actualClient.Id + " прошел контроль");
                    }
                    else
                    {
                        break;

                    }
                }
            }
            if (workers.Count == 0 && clients.Count > 0)
            {
                richTextBoxInfo.AppendText("\nУказанного количества персонала не хватило, чтобы обработать указанное количество пассажиров\n");
                richTextBoxInfo.AppendText("\nОсталось " + clients.Count + "  пассажиров и для их обслуживания требуется еще минимум - " + clients.Count * TimeOnClient + " секунд\n");
                richTextBoxInfo.AppendText("\nДля данного количесва пассажиров требуется еще " + (clients.Count * TimeOnClient) / workersCountForError + " сотрудников\n");


                MessageBox.Show("Указанного количества персонала не хватило, чтобы обработать указанное количество пассажиров");

            }
        }
        private void Init()
        {
            workers = new Queue<Worker>();
            clients = new Queue<Client>();

            int actualRemainingTime = ShiftTime / workersCount;
            for (int i = 0; i < workersCount; i++)
            {
                workers.Enqueue(new Worker(i + 1, actualRemainingTime));
                richTextBoxInfo.AppendText("\nБыла создан работник №  -  " + (i + 1));
            }
            richTextBoxInfo.AppendText("\nВсего на смене " + workersCount + " работников");

            for (int i = 0; i < clientsCount; i++)
            {
                clients.Enqueue(new Client(i + 1));
            }
            richTextBoxInfo.AppendText("\nВсего на смене " + clientsCount + " клиентов");
        }

        public void Draw ()
        {
            var form = Container.Resolve<FormVisualization>();
            form.ShowDialog();
        }
    }
}
