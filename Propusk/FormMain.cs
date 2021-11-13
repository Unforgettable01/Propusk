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

        private int ShiftCount = 0; // кол-во смен
        private int ClientCountStart = 0;
        private int ClientCountFinish = 0;


        public DrawInfo DrawInfo { get; private set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ShiftCount ++; // при нажатии кол-во смен увеличивается на 1, чтобы модно было отследить как формировать очереди работников и посетителей            
            workersCount = Convert.ToInt32(comboBoxCountWorkers.SelectedItem.ToString());
            Random rand =new Random();
            ClientCountStart =Convert.ToInt32(comboBoxCountClientsStart.SelectedItem.ToString());
            ClientCountFinish = Convert.ToInt32(comboBoxCountClientsFinish.SelectedItem.ToString());
            clientsCount = rand.Next(ClientCountStart, ClientCountFinish);
            Shedule();
        }
        private void buttonSaveReport_Click(object sender, EventArgs e)
        {
            string filename = "C:\\Users\\borya\\Downloads\\propusk.txt"; // путь к файлу, в котором нахолится отчет
            try
            {
                File.WriteAllText(filename, richTextBoxInfo.Text);   // Идет запись в файл (аргумент 1 , аргумент 2  )  1 - путь к файлу   2  -  сам текс, который записывется
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
            if (ShiftCount  == 1 || ShiftCount == 4 || ShiftCount == 7 )
            {
                InitOne();
            }
            else
            {
                InitTwo();
                Draw();
            }
            //else if (ShiftCount ==3)
            //{
            //    InitTwo();
            //}
            //else if (ShiftCount==4)
            //{
            //    //MessageBox.Show("Укажите новое кол-во сотрудников", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //   // DialogResult = DialogResult.OK;
            //    InitOne();
            //}
            //else if (ShiftCount > 4)
            //{
            //    richTextBoxInfo.AppendText("")
            //}
            richTextBoxInfo.AppendText("\nНачалась смена № - " + ShiftCount);
            richTextBoxInfo.AppendText("\n\n");
            richTextBoxInfo.AppendText("\n|---------------------------------------------------------------------------------------|\n");

            while (workers.Count != 0)
            {
                if (clients.Count == 0)
                {

                    break;
                }
                Worker actualWorker = workers.Dequeue();
                Client actualClient = clients.Dequeue();              
                richTextBoxInfo.AppendText("\n Работник № - " + actualWorker.Id  + " обработал клиента № - " + actualClient.Id);

            }
            richTextBoxInfo.AppendText("\nВ очереди осталось " + clients.Count + " человек\n");
        }
        private void InitOne()
        {
            workers = new Queue<Worker>();
            clients = new Queue<Client>();

            
            for (int i = 0; i < workersCount; i++)
            {
                workers.Enqueue(new Worker(i + 1));
                //richTextBoxInfo.AppendText("\nБыл создан работник №  -  " + (i + 1));
            }
            richTextBoxInfo.AppendText("\nВсего на смене " + workers.Count + " работников");

            for (int i = 0; i < clientsCount; i++)
            {
                clients.Enqueue(new Client(i + 1));
            }
            richTextBoxInfo.AppendText("\nВсего на смене " + clients.Count + " клиентов");
        }

        private void InitTwo()
        {
            workers = new Queue<Worker>();
            for (int i = 0; i < workersCount; i++)
            {
                workers.Enqueue(new Worker(i + 1));
                //richTextBoxInfo.AppendText("\nБыл создан работник №  -  " + (i + 1));
            }
            richTextBoxInfo.AppendText("\nВсего на смене " + workers.Count + " работников");


            int clientCountNew = clients.Count + clientsCount;
            richTextBoxInfo.AppendText("\nОсталось - " + clients.Count + " пришло " + clientsCount);
            for (int i = clients.Count; i < clientCountNew; i++)
            {
                clients.Enqueue(new Client(i + 1));
            }
            richTextBoxInfo.AppendText("\nВсего на смене " + clients.Count + " клиентов ");
        }


        public void Draw ()
        {
            var form = Container.Resolve<FormVisualization>();
            form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormVisualization>();
            form.ShowDialog();
        }
    }
}
