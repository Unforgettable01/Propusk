using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Unity;

namespace Propusk
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private Algorithm sheduler;
        private Queue<Worker> workers;  // очередь работников 
        private Queue<Client> clients;  // очередь клиентов 
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sheduler = new Algorithm(240, Convert.ToInt32(comboBoxCountWorkers.SelectedItem.ToString()), Convert.ToInt32(comboBoxCountVisitors.SelectedItem.ToString()));
            richTextBoxInfo.Text = sheduler.Shedule().ToString();
            Render();
        }
        private void Render()
        {
            // Bitmap map = new Bitmap(pictureBox.Width, sheduler.DrawInfo.GetHeight());
            // Graphics g = Graphics.FromImage(map);
            //sheduler.DrawInfo.Render(g);
            // pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            // pictureBox1.Image = map;
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
    }
}
