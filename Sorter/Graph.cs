using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    public class Graph
    {
        int[] arr;
        public Graph(int[] arr)
        {
            this.arr = arr;
        }

        public void setArray(int[] arr)
        {
            this.arr = arr;
        }
        
        private int getColumnSize(int widht, int indent,int[] arr)
        {
            widht -= indent;
            return (widht / arr.Length) - indent;
        }

        public void display(Size clientsize, Graphics g)
        {
            int indent = 20;
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, clientsize.Width- 1, clientsize.Height - 1));
            int columnSize = getColumnSize(clientsize.Width, indent, arr);
            for (int i = 0; i < arr.Length; i++)
            {
                g.FillRectangle(Brushes.LightGray, new Rectangle((columnSize * i) + indent, 30, 30, 20));
            }
        }

    }
}
