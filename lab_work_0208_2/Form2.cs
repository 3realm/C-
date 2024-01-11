using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_work_0208_2
{
    public partial class Form2 : Form
    {
        // модуль
        public double GetNorm(ListBox listBox)
        {
            double norm;
            int vv = 0;
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                vv += (int)Math.Pow(int.Parse(listBox.Items[i].ToString()), 2);
            }
            return norm = Math.Sqrt(vv);
        }

        // сумма
        public int[] Summ(ListBox listBox1, ListBox listBox2)
        {
            int[] result = new int[listBox1.Items.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(listBox1.Items[i].ToString()) + int.Parse(listBox2.Items[i].ToString());
            }
            return result;
        }

        public string Print(int[] result)
        {
            string s = " ";
            for (int i = 0; i < result.Length; i++)
            {
                s += result[i] + " ";
            }
            return s;
        }

        // произведение
        public double Scalar(ListBox listBox1, ListBox listBox2)
        {
            double multi = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                multi += int.Parse(listBox1.Items[i].ToString()) * int.Parse(listBox2.Items[i].ToString());
            }
            return multi;       
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * сумма элементов списка
            int sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += int.Parse(listBox1.Items[i].ToString());
            }
            */

            // кнопка для первого списка
            textBox2.Text = Convert.ToString(GetNorm(listBox1));            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // добавление в первый список
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // кнопка для второго списка
            textBox3.Text = Convert.ToString(GetNorm(listBox2));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // добавление во второй список
            listBox2.Items.Add(textBox5.Text);
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Items
            switch (comboBox1.Text)
            {
                case "+":
                    {
                        if (listBox1.Items.Count != listBox2.Items.Count)
                        {
                            MessageBox.Show("Ошибка разная размерность");
                        }
                        else
                        {
                            textBox4.Text = Print(Summ(listBox1, listBox2));
                        }
                        
                        break;
                    }
                case "*":
                    {
                        if (listBox1.Items.Count != listBox2.Items.Count)
                        {
                            MessageBox.Show("Ошибка разная размерность");
                        }
                        else
                        {
                            textBox4.Text = Convert.ToString(Scalar(listBox1, listBox2));
                        }
                        
                        break;
                    }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
