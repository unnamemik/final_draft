using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_draft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/unnamemik/final_draft");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string[] input_array = textBox1.Text.Split(' ');
            textBox2.Text = "[" + String.Join(", ", input_array) + "]";
            int output_arrsize = 0;
            string[] output_array = new string[output_arrsize];

            for (int i = 0; i < input_array.Length; i++)
            {
                if (input_array[i].Length <= 3)
                {                    
                    Array.Resize(ref output_array, output_arrsize+1);
                    output_array[output_arrsize] = input_array[i];
                    output_arrsize++;
                }
            }
            textBox3.Text = "[" + String.Join(", ", output_array) + "]";
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            textBox2.Text = "Исходный массив:";
            textBox3.Text = "Результат";
            textBox4.Text = "0";
            textBox5.Text = "0";
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            int diapazon = int.Parse(textBox4.Text);
            int rand_Array_size = int.Parse(textBox5.Text);
            int[] rand_Array = new int[rand_Array_size];
            Random rand = new Random();

            for (int x = 0; x < rand_Array.Length; x++)
            {
                rand_Array[x] = rand.Next(diapazon);
            }
            textBox2.Text = "[" + String.Join(", ", rand_Array) + "]";
            int output_arrsize = 0;
            int[] output_array = new int[output_arrsize];

            for (int i = 0; i < rand_Array.Length; i++)
            {
                if (rand_Array[i] <= 999)
                {
                    Array.Resize(ref output_array, output_arrsize + 1);
                    output_array[output_arrsize] = rand_Array[i];
                    output_arrsize++;
                }
            }
            textBox3.Text = "[" + String.Join(", ", output_array) + "]";
        }  

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            textBox2.Text = fileText;

            string[] input_array = textBox2.Text.Split(' ');
            textBox2.Text = "[" + String.Join(", ", input_array) + "]";
            int output_arrsize = 0;
            string[] output_array = new string[output_arrsize];

            for (int i = 0; i < input_array.Length; i++)
            {
                if (input_array[i].Length <= 3)
                {

                    Array.Resize(ref output_array, output_arrsize + 1);
                    output_array[output_arrsize] = input_array[i];
                    output_arrsize++;
                }
            }
            textBox3.Text = "[" + String.Join(", ", output_array) + "]";
        }
    }
}
