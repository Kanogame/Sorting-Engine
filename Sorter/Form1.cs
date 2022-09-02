using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class Form1 : Form
    {
        Graph graph;
        int[] arr;
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
            graph = new Graph(arr);
            Randomize();
        }

        private void repaintRequired()
        {
            Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            graph.display(Size, e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randomize();
            repaintRequired();
            graph.setArray(arr);
        }

        private void Randomize()
        {
            try
            {
                arr = new int[int.Parse(textBox1.Text)];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr = Enumerable.Range(1, arr.Length + 1).OrderBy(x => rd.Next()).Take(arr.Length).ToArray();
                }
                graph.setArray(arr);
            }
            catch (Exception)
            {
                MessageBox.Show("количество переменных не является числом");
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
