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

        public Form1()
        {
            InitializeComponent();
            graph = new Graph(arr);
            Randomize();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            repaintRequired();
        }

        private void repaintRequired()
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            graph.display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randomize();
            repaintRequired();
        }

        private void Randomize()
        {
            try
            {
                arr = new int[int.Parse(textBox1.Text)];
                for (int i = 0; i < arr.Length; i++)
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("количество переменных не является числом");
            }
        }
    }
}
