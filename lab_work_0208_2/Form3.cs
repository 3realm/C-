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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string PrintList()
        {
            string[] s = textBox1.Text.Split(new char[] { ' ' });
            
            return s.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {


            int count = (int)numericUpDown1.Value;
            IVectorable[] arr = new IVectorable[count];

            if (count != listBox1.Items.Count)
            {
                MessageBox.Show("Размерность не соответствует заданной");                
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    string[] s = listBox1.Items[i].ToString().Split(new char[] { ' ' });

                    switch (comboBox1.Text)
                    {
                        case "ArrayVector":
                            {
                                arr[i] = new ArrayVector(s.Length);

                                for (int j = 0; j < s.Length; j++)
                                {
                                    // Значение {0}ого элемента
                                    arr[i][j] = Convert.ToInt32(s[j]);
                                }
                                break;
                            }

                        case "LinkedListVector":
                            {
                                arr[i] = new LinkedListVector(s.Length);

                                for (int j = 0; j < s.Length; j++)
                                {
                                    arr[i][j] = Convert.ToInt32(s[j]);
                                }
                                break;
                            }
                    }
                }

                IVectorable max = arr[0];
                IVectorable min = arr[0];
                int value;

                for (int i = 0; i < count; i++)
                {
                    value = min.CompareTo(arr[i]);
                    if (value < 0)
                    {
                        min = arr[i];
                    }
                }

                for (int i = 0; i < count; i++)
                {
                    value = max.CompareTo(arr[i]);
                    if (value > 0)
                    {
                        max = arr[i];
                    }
                }

                // Сортировка
                Array.Sort(arr, new Additional());
                for (int i = 0; i < count; i++)
                {
                    textBox4.AppendText(arr[i].ToString());
                }

                // Минимальное количество координат в векторе
                for (int i = 0; i < count; i++)
                {
                    // их может быть несколько
                    if (arr[i].Length == min.Length)
                    {
                        textBox3.Text = arr[i].ToString();
                    }
                }

                // Максимальное количество координат в векторе           
                for (int i = 0; i < count; i++)
                {
                    if (arr[i].Length == max.Length)
                    {
                        textBox2.Text = arr[i].ToString();
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            listBox1.Items.Add(textBox1.Text);

            textBox1.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
