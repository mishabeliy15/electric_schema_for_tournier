using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace electric_shema
{
    public partial class Form1 : Form
    {
        PictureBox[,] kletka;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Red), 10, 10, 100, 100);*/
            //contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            kletka = new PictureBox[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    kletka[i, j] = new PictureBox();
                    kletka[i, j].BorderStyle = BorderStyle.FixedSingle;
                    kletka[i, j].Size = new Size(50, 50);
                    kletka[i, j].Location = new Point(50 * j, 50 * i);
                    kletka[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Schema.Controls.Add(kletka[i, j]);
                }
        }
    }
}