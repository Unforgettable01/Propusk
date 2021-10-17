using System.Drawing;
using System.Windows.Forms;

namespace Propusk
{
    public partial class FormVisualization : Form
    {
        public FormVisualization()
        {
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            int x =0;
            int y=0;
            int _width=100;
            int _height=100;
            Bitmap bmp = new Bitmap(pictureBoxVisualization.Width, pictureBoxVisualization.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue);

            while (_width < pictureBoxVisualization.Width)
            {
                for (int i = 0; i<8; i ++)
                {
                    pictureBoxVisualization.Image = null;
                    x += 50;
                    _width += 50;
                    graph.DrawRectangle(pen, x, y, _width, _height);
                    pictureBoxVisualization.Image = bmp;
                    //System.Threading.Thread.Sleep(50);

                }
            }

           // this.Close();
        }
    }
}
