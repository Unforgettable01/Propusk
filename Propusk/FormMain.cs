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
        private int numberSituation = 0;
        private int[] massShiftForUpdateDictionary = {1,4,7,10,13,16,19,22,25,28,31,34,37,40,43,46,49,52,55};

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxCountClientsStart.Text))
            {
                MessageBox.Show("Заполните начальную границу количества посетителей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxCountClientsFinish.Text))
            {
                MessageBox.Show("Заполните конечную границу количества посетителей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxCountWorkers.Text))
            {
                MessageBox.Show("Заполните количество персонала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(comboBoxCountClientsStart.Text)> Convert.ToInt32(comboBoxCountClientsFinish.Text))
            {
                MessageBox.Show("Левая граница кол-ва посетителей не может быть больше правой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ShiftCount++; // при нажатии кол-во смен увеличивается на 1, чтобы модно было отследить как формировать очереди работников и посетителей
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
        public void Shedule()
        {
            for (int i = 0; i < massShiftForUpdateDictionary.Length; i++)
            {
                if (ShiftCount == massShiftForUpdateDictionary[i] && i == 0)
                {
                    numberSituation = 1;
                    richTextBoxInfo.SelectionFont = new Font("Tahoma", 12, FontStyle.Bold);
                    richTextBoxInfo.AppendText("\nДанные о количестве персонала и посетителей успешно получены");
                    InitOne();
                    Draw();
                    break;
                }
                else if (ShiftCount == massShiftForUpdateDictionary[i])
                {
                    numberSituation = 1;
                    richTextBoxInfo.SelectionFont = new Font("Tahoma", 12, FontStyle.Bold);
                    richTextBoxInfo.AppendText("\nДанные о количестве персонала и посетителей успешно получены");
                    InitOne();
                    Draw();
                    break;
                }
                else if (ShiftCount != massShiftForUpdateDictionary[i] && i == massShiftForUpdateDictionary.Length -1)
                {
                    numberSituation = 3;
                    InitTwo();
                    Draw();
                }
            }
            richTextBoxInfo.SelectionFont = new Font("Tahoma", 14, FontStyle.Bold);
            richTextBoxInfo.AppendText("\n\tНачалась смена № - " + ShiftCount);
            richTextBoxInfo.SelectionFont = new Font("Ariel", 9);
            richTextBoxInfo.AppendText("\n___________________________________________________________");

            numberSituation = 2;
            Draw();

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
            richTextBoxInfo.SelectionFont = new Font("Ariel", 10);
            richTextBoxInfo.SelectionColor = System.Drawing.Color.Red;
            numberSituation = 3;
            Draw();
            richTextBoxInfo.AppendText("\nВ очереди осталось " + clients.Count + " человек\n");
        }
        private void InitOne()
        {
            workers = new Queue<Worker>();
            clients = new Queue<Client>();
           
            for (int i = 0; i < workersCount; i++)
            {
                workers.Enqueue(new Worker(i + 1));
            }
            richTextBoxInfo.SelectionFont = new Font("Tahoma", 12);
            richTextBoxInfo.AppendText("\nВсего на смене " + workers.Count + " работников");

            for (int i = 0; i < clientsCount; i++)
            {
                clients.Enqueue(new Client(i + 1));
            }
            richTextBoxInfo.SelectionFont = new Font("Tahoma", 12);
            richTextBoxInfo.AppendText("\nВсего на смене " + clients.Count + " клиента(ов)");
        }

        private void InitTwo()
        {
            workers = new Queue<Worker>();
            for (int i = 0; i < workersCount; i++)
            {
                workers.Enqueue(new Worker(i + 1));
            }
            richTextBoxInfo.SelectionFont = new Font("Tahoma", 12);
            richTextBoxInfo.AppendText("\nВсего на смене " + workers.Count + " работников");

            int clientCountNew = clients.Count + clientsCount;
            richTextBoxInfo.AppendText("\nОсталось - " + clients.Count + " пришло " + clientsCount);
            for (int i = clients.Count; i < clientCountNew; i++)
            {
                clients.Enqueue(new Client(i + 1));
            }
            richTextBoxInfo.SelectionFont = new Font("Tahoma", 12);
            richTextBoxInfo.AppendText("\nВсего на смене " + clients.Count + " клиентов ");
        }

        public void Draw ()
        {
            var form = Container.Resolve<FormVisualization>();
            form.numberSituation = this.numberSituation;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormVisualization>();
            form.numberSituation = 1;
            form.ShowDialog();
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
    }
}
