using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;
            Button[,] btn = new Button[8, 8];
            for (int i = 0; i <= btn.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= btn.GetUpperBound(1); j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Width = 80;
                    btn[i, j].Height = 80;
                    btn[i, j].Left = left;
                    btn[i, j].Top = top;
                    left += 81;
                    if ((i+j)%2==0)
                    {
                        btn[i,j].BackColor = Color.Black;
                    }
                    else
                    {
                        btn[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(btn[i, j]);
                }

                top += 81;
                left = 0;
            }

        }
    }
}
