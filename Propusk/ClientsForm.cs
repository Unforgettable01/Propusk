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
    public partial class ClientsForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ClientLogic _clientLogic;
        public ClientsForm(ClientLogic clientLogic)
        {
            InitializeComponent();
            _clientLogic = clientLogic;
        }

        private void LoadData()
        {
            try
            {
                var list = _clientLogic.Read(null);
                if (list != null)
                {
                    dataGridViewClients.DataSource = list;
                    dataGridViewClients.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

        }
    }
}
