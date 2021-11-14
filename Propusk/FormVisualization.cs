using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propusk
{
    public partial class FormVisualization : Form
    {
        private Bitmap bmp;//Здесь рисуем
        public int numberSituation = 0;
        public FormVisualization()
        {
            InitializeComponent();

        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height); /// В  формe задаёшь размер Bitmap
            if (numberSituation == 1)
            {
                DrawLine();
                DrawPropusk();
                DrawPeopleOnTheLeft();
            }
            else if (numberSituation == 2)
            {
                DrawLine();
                DrawPropusk();
                DrawPeopleOnTheLeft();
                DrawPeopleOnThePropusk();
                DrawPeopleOntheRight();
            }
            else if (numberSituation == 3)
            {
                DrawLine();
                DrawPropusk();
                DrawPeopleOnTheLeft();
                DrawPeopleOntheRight();
            }
        }
        async private void FormVisualization_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000); // 5 секунд
            Close();

        }
        public  void DrawPeopleOnTheLeft()
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {

                // рисуем человечков для 1-ого пункта
                Pen penPeople = new Pen(Color.Green, 3);
                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5); // тело 

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 15, pictureBox.Height / 6,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60); //левая рука

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 45, pictureBox.Height / 6); //правая рука


                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 45, pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 15, pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 13, pictureBox.Height / 3 - pictureBox.Height / 3 + 10,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);

                // рисуем человечков для 2-ого пункта
                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3); // тело 

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 15, pictureBox.Height / 6 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3); //левая рука

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 45, pictureBox.Height / 6 + pictureBox.Height / 3); //правая рука


                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 45, pictureBox.Height / 3 + pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 15, pictureBox.Height / 3 + pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 13, pictureBox.Height / 3 - pictureBox.Height / 3 + 10 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);

                // рисуем человечков для 3-ого пункта
                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3); // тело 

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 15, pictureBox.Height / 6 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3 + pictureBox.Height / 3); //левая рука

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 45, pictureBox.Height / 6 + pictureBox.Height / 3 + pictureBox.Height / 3); //правая рука


                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 45, pictureBox.Height / 3 + pictureBox.Height / 3 + pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 15, pictureBox.Height / 3 + pictureBox.Height / 3 + pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width / 2 - pictureBox.Width / 2 + 13, pictureBox.Height / 3 - pictureBox.Height / 3 + 10 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);
            }
            pictureBox.Image = bmp;
        }

        public void DrawLine()
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.Black, 3);   // создали элемент, которым будем рисовать и указали цвет и тольщину
                //рисуем линии разграничения пунктов - кол-во сотрудников 
                g.DrawLine(pen, 0, pictureBox.Height / 3, pictureBox.Width, pictureBox.Height / 3);   //первая линия 
                g.DrawLine(pen, 0, pictureBox.Height / 3 * 2, pictureBox.Width, pictureBox.Height / 3 * 2);  //вторая линия
                g.DrawLine(pen, 0, pictureBox.Height / 3 * 3 - 1, pictureBox.Width, pictureBox.Height / 3 * 3 - 1);  //третья лигия
            }
            pictureBox.Image = bmp;
        }
        public void DrawPropusk()
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // рисуем сами пункты пропуска 
                Pen penRect = new Pen(Color.Brown, 5);
                g.DrawRectangle(penRect, pictureBox.Width / 2 - pictureBox.Width / 12, pictureBox.Height / 3 - pictureBox.Height / 3 + 10,
                    pictureBox.Width / 12, pictureBox.Height / 3 - 10);
                g.DrawRectangle(penRect, pictureBox.Width / 2 - pictureBox.Width / 12, pictureBox.Height / 3 * 2 - pictureBox.Height / 3 + 10,
                    pictureBox.Width / 12, pictureBox.Height / 3 - 10);
                g.DrawRectangle(penRect, pictureBox.Width / 2 - pictureBox.Width / 12, pictureBox.Height / 3 * 3 - 1 - pictureBox.Height / 3 + 10,
                    pictureBox.Width / 12, pictureBox.Height / 3 - 10);
            }
            pictureBox.Image = bmp;
        }
        public void DrawPeopleOntheRight()
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen penPeople = new Pen(Color.Green, 3);

                // рисуем человечков для 1-ого пункта  правая часть
                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42,
                    pictureBox.Width - 30, pictureBox.Height / 5); // тело 

                g.DrawLine(penPeople, pictureBox.Width - 15, pictureBox.Height / 6,
                    pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60); //левая рука

                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60,
                    pictureBox.Width - 45, pictureBox.Height / 6); //правая рука


                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 5,
                    pictureBox.Width - 45, pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 5,
                    pictureBox.Width - 15, pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width - 23 * 2, pictureBox.Height / 3 - pictureBox.Height / 3 + 10,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);

                // рисуем человечков для 2-ого пункта правая часть 
                g.DrawLine(penPeople, pictureBox.Width - +30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42 + pictureBox.Height / 3,
                    pictureBox.Width - +30, pictureBox.Height / 5 + pictureBox.Height / 3); // тело 

                g.DrawLine(penPeople, pictureBox.Width - 15, pictureBox.Height / 6 + pictureBox.Height / 3,
                    pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3); //левая рука

                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3,
                    pictureBox.Width - 45, pictureBox.Height / 6 + pictureBox.Height / 3); //правая рука


                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 5 + pictureBox.Height / 3,
                    pictureBox.Width - 45, pictureBox.Height / 3 + pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 5 + pictureBox.Height / 3,
                    pictureBox.Width - 15, pictureBox.Height / 3 + pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width - 46, pictureBox.Height / 3 - pictureBox.Height / 3 + 10 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);

                // рисуем человечков для 3-ого пункта правая часть
                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width - 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3); // тело 

                g.DrawLine(penPeople, pictureBox.Width - 15, pictureBox.Height / 6 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3 + pictureBox.Height / 3); //левая рука

                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width - 45, pictureBox.Height / 6 + pictureBox.Height / 3 + pictureBox.Height / 3); //правая рука


                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width - 45, pictureBox.Height / 3 + pictureBox.Height / 3 + pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width - 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width - 15, pictureBox.Height / 3 + pictureBox.Height / 3 + pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width - 46, pictureBox.Height / 3 - pictureBox.Height / 3 + 10 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);
            }
            pictureBox.Image = bmp;
        }
        public async void DrawPeopleOnThePropusk()
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // рисуем человечков для 1-ого пункта
                Pen penPeople = new Pen(Color.Green, 3);
                g.DrawLine(penPeople, pictureBox.Width / 2  + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42,
                    pictureBox.Width / 2   + 30, pictureBox.Height / 5); // тело 

                g.DrawLine(penPeople, pictureBox.Width / 2  + 15, pictureBox.Height / 6,
                    pictureBox.Width / 2  + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60); //левая рука

                g.DrawLine(penPeople, pictureBox.Width / 2   + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60,
                    pictureBox.Width / 2  + 45, pictureBox.Height / 6); //правая рука


                g.DrawLine(penPeople, pictureBox.Width / 2 + 30, pictureBox.Height / 5,
                    pictureBox.Width / 2 + 45, pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width / 2  + 30, pictureBox.Height / 5,
                    pictureBox.Width / 2 + 15, pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width / 2  + 13, pictureBox.Height / 3 - pictureBox.Height / 3 + 10,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);

                // рисуем человечков для 2-ого пункта
                g.DrawLine(penPeople, pictureBox.Width / 2  + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42 + pictureBox.Height / 3,
                    pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3); // тело 

                g.DrawLine(penPeople, pictureBox.Width / 2  + 15, pictureBox.Height / 6 + pictureBox.Height / 3,
                    pictureBox.Width / 2  + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3); //левая рука

                g.DrawLine(penPeople, pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3,
                    pictureBox.Width / 2  + 45, pictureBox.Height / 6 + pictureBox.Height / 3); //правая рука


                g.DrawLine(penPeople, pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3,
                    pictureBox.Width / 2 + 45, pictureBox.Height / 3 + pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3,
                    pictureBox.Width / 2  + 15, pictureBox.Height / 3 + pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width / 2  + 13, pictureBox.Height / 3 - pictureBox.Height / 3 + 10 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);

                // рисуем человечков для 3-ого пункта
                g.DrawLine(penPeople, pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 42 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3); // тело 

                g.DrawLine(penPeople, pictureBox.Width / 2 + 15, pictureBox.Height / 6 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3 + pictureBox.Height / 3); //левая рука

                g.DrawLine(penPeople, pictureBox.Width / 2  + 30, pictureBox.Height / 3 - pictureBox.Height / 3 + 60 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 + 45, pictureBox.Height / 6 + pictureBox.Height / 3 + pictureBox.Height / 3); //правая рука


                g.DrawLine(penPeople, pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2  + 45, pictureBox.Height / 3 + pictureBox.Height / 3 + pictureBox.Height / 3); //правая нога

                g.DrawLine(penPeople, pictureBox.Width / 2 + 30, pictureBox.Height / 5 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 + 15, pictureBox.Height / 3 + pictureBox.Height / 3 + pictureBox.Height / 3); //левая нога

                g.DrawEllipse(penPeople, pictureBox.Width / 2  + 13, pictureBox.Height / 3 - pictureBox.Height / 3 + 10 + pictureBox.Height / 3 + pictureBox.Height / 3,
                    pictureBox.Width / 2 - pictureBox.Width / 2 + 34, pictureBox.Height / 3 - pictureBox.Height / 3 + 34);
            }
            pictureBox.Image = bmp;
        }
    }
}
