using Logic.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Propusk
{
    public partial class WorkersForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly WorkerLogic _workerLogic;
        public WorkersForm(WorkerLogic workerLogic)
        {
            InitializeComponent();
            _workerLogic = workerLogic;
        }

        private void LoadData()
        {
            try
            {
                var list = _workerLogic.Read(null);
                if (list != null)
                {
                    dataGridViewWorkers.DataSource = list;
                    dataGridViewWorkers.Columns[0].Visible = false;
                    //dataGridViewWorkers.Columns[2].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void FormWorker_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {

        }
    }
}
