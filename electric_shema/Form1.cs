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
using System.IO;

namespace electric_shema
{
    public partial class Form1 : Form
    {
        PictureBox[,] kletka;
        schema_json schema_now;
        public Form1()
        {
            InitializeComponent();
            kletka = new PictureBox[10, 10];
            schema_now = new schema_json();
            schema_now.kletka = new box[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    kletka[i, j] = new PictureBox();
                    kletka[i, j].BorderStyle = BorderStyle.FixedSingle;
                    kletka[i, j].Size = new Size(50, 50);
                    kletka[i, j].Location = new Point(50 * j, 50 * i);
                    kletka[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    kletka[i, j].Click += picture_click;
                    this.Schema.Controls.Add(kletka[i, j]);
                    schema_now.kletka[i, j] = new box();
                }
        }
        private void picture_click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (sender.Equals(kletka[i, j]))
                    {
                        if (this.Cursor == System.Windows.Forms.Cursors.Hand)
                        {
                            kletka[i, j].Image = who_checked().Image;
                            schema_now.kletka[i, j].Name = who_checked().Name;
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                        }
                        break;
                    }
        }
        private PictureBox who_checked()
        {
            if (radioButton1.Checked) return resistor;
            else if (radioButton2.Checked) return battery;
            else if (radioButton3.Checked) return voltmetr;
            else if (radioButton4.Checked) return ampmetr;
            else if (radioButton5.Checked) return onof;
            else return null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string serialized = JsonConvert.SerializeObject(schema_now);
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(serialized);
                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                StreamReader se = new StreamReader(openFileDialog1.FileName);
                string s = se.ReadLine();
                schema_now = JsonConvert.DeserializeObject<schema_json>(s);
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        if (schema_now.kletka[i, j].Name != null)
                        {
                            kletka[i, j].Image = who_name(schema_now.kletka[i, j].Name).Image;
                        }
                        else
                            kletka[i, j].Image = new Bitmap(50,50);
            }
        }
        private PictureBox who_name(string name)
        {
            if (name == resistor.Name)
                return resistor;
            else if (name == battery.Name)
                return battery;
            else if (name == voltmetr.Name)
                return voltmetr;
            else if (name == ampmetr.Name)
                return ampmetr;
            else if (name == onof.Name)
                return onof;
            else
                return null;
        }
    }
}