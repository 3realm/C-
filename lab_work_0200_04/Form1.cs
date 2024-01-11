using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_work_0200_04
{
    public partial class Form1 : Form
    {
        Graphics graph;
        Pen pen;

        // Точка вращения
        PointF r;
        PointF kr;
        PointF cr;

        // Координаты
        PointF[] o;
        PointF[] oo;

        // Угол
        int angle;

        int rad;
        int rad_long;
        int x;
        int y;

        char zn = '+';
        int rap = 100;

        // Круг
        void DrawCircles(int x, int y)
        {
            rad_long = rad + 100;

            graph.DrawEllipse(pen, x, y, rad, rad);
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph = pictureBox1.CreateGraphics();

            SolidBrush fon = new SolidBrush(Color.Black);
            graph.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // Контур
            pen = new Pen(Color.Red);
            rad = 50;

            x = 150;
            y = 150;

            // graph.TranslateTransform(0.0F, 0.0F);
            // graph.RotateTransform(90.0F);
            // graph.DrawEllipse(new Pen(Color.Blue, 3), 0, 0, rad, rad+100);

            // pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // Graphics g = Graphics.FromImage(pictureBox1.Image);
            // Координаты объекта
            o = new PointF[] { new PointF(100, 100), new PointF(200, 100), new PointF(100, 200) };

            oo = new PointF[] { new PointF(100, 100), new PointF(200, 100), new PointF(200, 200), new PointF(100, 200) };

            // Рисуем объект для поворота (треугольник)
            //graph.DrawPolygon(Pens.White, o);

            // Рисуем объект для поворота (квадрат)
            //graph.DrawPolygon(Pens.White, oo);

            // точка относительно которой поворачиваем
            r = new PointF(150, 150);

            kr = new PointF(150, 150);

            cr = new PointF(rad, rad_long);

            // переводим угол в радианты
            double angleRadian = angle * Math.PI / 180;
            // для хранения новых координат обхекта
            PointF[] _r = new PointF[o.Length];

            PointF[] _kr = new PointF[oo.Length];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Включение
            // timer1.Enabled = true;
            // Вкл/Выкл
            timer1.Enabled = !timer1.Enabled;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            timer2.Enabled = !timer2.Enabled;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            timer3.Enabled = !timer3.Enabled;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            graph.Clear(Color.Black);

            double angleRadian = angle * Math.PI / 180;

            PointF[] _r = new PointF[o.Length];

            for (int j = 0; j < o.Length; j++)
            {
                float _x = (float)((o[j].X - r.X) * Math.Cos(angleRadian) - (o[j].Y - r.Y) * Math.Sin(angleRadian) + r.X);
                float _y = (float)((o[j].X - r.X) * Math.Sin(angleRadian) + (o[j].Y - r.Y) * Math.Cos(angleRadian) + r.Y);
                _r[j] = new PointF(_x, _y);
            }

            angle++;

            for (int i = 0; i < o.Length; i++)
            {
                switch (zn)
                {
                    case '-':
                        rap--;
                        // _r[i].Y += rap;
                        _r[i].X += rap;
                        break;
                    case '+':
                        rap++;
                        _r[i].X += rap;
                        // _r[i].Y += rap;
                        break;
                }

                if (_r[i].X > 450)
                {
                    zn = '-';
                }
                if (_r[i].X < 15)
                {
                    zn = '+';
                }
            }

            rap++;

            graph.DrawPolygon(Pens.Red, _r);
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            graph.Clear(Color.Black);

            double angleRadian = angle * Math.PI / 180;

            PointF[] _kr = new PointF[oo.Length];

            for (int j = 0; j < oo.Length; j++)
            {
                float _x = (float)((oo[j].X - kr.X) * Math.Cos(angleRadian) - (oo[j].Y - kr.Y) * Math.Sin(angleRadian) + kr.X);
                float _y = (float)((oo[j].X - kr.X) * Math.Sin(angleRadian) + (oo[j].Y - kr.Y) * Math.Cos(angleRadian) + kr.Y);
                _kr[j] = new PointF(_x, _y);
            }

            angle++;

            for (int i = 0; i < oo.Length; i++)
            {
                switch (zn)
                {
                    case '-':
                        rap--;
                        _kr[i].X += rap;
                        break;
                    case '+':
                        rap++;
                        _kr[i].X += rap;
                        break;
                }

                if (_kr[i].X > 450)
                {
                    zn = '-';
                }
                if (_kr[i].X < 15)
                {
                    zn = '+';
                }
            }

            graph.DrawPolygon(Pens.Red, _kr);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format("Текущее значение Interval: {0}", trackBar1.Value);

            int intervsl = this.trackBar1.Value;

            timer1.Interval = intervsl;

            timer2.Interval = intervsl;

            timer3.Interval = intervsl;
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            graph.Clear(Color.Black);

            /*
            double angleRadian = angle * Math.PI / 180;

            int xc = rad_long - rad;
            int yc = rad - rad_long;

            float _x = (float)((x - cr.X) * Math.Cos(angleRadian) - (y - cr.Y) * Math.Sin(angleRadian) + cr.X);
            float _y = (float)((x - cr.X) * Math.Sin(angleRadian) + (y - cr.Y) * Math.Cos(angleRadian) + cr.Y);
            */
            switch (zn)
            {
                case '-':
                    x -= 5;
                    break;
                case '+':
                    x += 5;
                    break;
            }

            if (x > 450)
            {
                zn = '-';
            }
            if (x < 15)
            {
                zn = '+';
            }

            graph.DrawEllipse(pen, x, y, rad, rad);



            /*
            graph.TranslateTransform(0.0F, 0.0F);
            graph.RotateTransform(angle_d);
            graph.DrawEllipse(new Pen(Color.Blue, 3), 0, 0, 50, 150);
            angle_d = angle_d + 1.0F;
            */
        }
    }
}
