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

        private PictureBox createPictureBox(int x,int y)
        {
            PictureBox pict = new PictureBox();
            pict.BorderStyle = BorderStyle.FixedSingle;
            pict.Size = new Size(50, 50);
            pict.Location = new Point(50 * x, 50 * y);
            pict.SizeMode = PictureBoxSizeMode.Zoom;
            pict.Click += picture_click;
            pict.ContextMenuStrip = contextMenuStrip1;
            this.Schema.Controls.Add(pict);
            return pict;
        }
        private void CreateNewSchem()
        {
            if (kletka != null)
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        kletka[i, j].Dispose();
            kletka = new PictureBox[10, 10];            
            schema_now = new schema_json();
            schema_now.kletka = new box[10, 10];
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    kletka[i, j] = createPictureBox(j, i);
                    schema_now.kletka[i, j] = new box();
                }
        }
        public Form1()
        {
            InitializeComponent();
            CreateNewSchem();
        }
        private void picture_click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (sender.Equals(kletka[i, j]))
                    {
                        if (this.Cursor == System.Windows.Forms.Cursors.Hand)
                        {
                            kletka[i, j].Image = new Bitmap(who_checked(i,j).Image);
                            schema_now.kletka[i, j].Name = who_checked(i,j).Name;
                            schema_now.kletka[i, j].Vertical = false;
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                        }
                        break;
                    }
        }
        private PictureBox who_checked(int i,int j)
        {
            if (radioButton1.Checked)
            {
                schema_now.kletka[i, j].Properties = new Resistor();
                (schema_now.kletka[i, j].Properties as Resistor).R = 1;
                return resistor;
            }
            else if (radioButton2.Checked)
            {
                return battery;
            }
            else if (radioButton3.Checked) return voltmetr;
            else if (radioButton4.Checked) return ampmetr;
            else if (radioButton5.Checked) return onof;
            else if (radioButton6.Checked) return Lampa;
            else if (radioButton7.Checked) return Provod;
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
                            if (schema_now.kletka[i, j].Vertical)
                            {
                                kletka[i, j].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                kletka[i, j].Refresh();
                            }

                        }
                        else
                            kletka[i, j].Image = new Bitmap(50,50);
                se.Close();
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
            else if (name == Lampa.Name)
                return Lampa;
            else if (name == Provod.Name)
                return Provod;
            else
                return null;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Удалить")
            {
                Point temp = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                kletka[temp.X, temp.Y].Name = null;
                kletka[temp.X, temp.Y].Image = new Bitmap(50, 50);
                schema_now.kletka[temp.X, temp.Y] = new box();
            }
            else if(e.ClickedItem.Text == "Перевернуть")
            {
                if ((contextMenuStrip1.SourceControl as PictureBox).Image != null)
                {
                    Point temp = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                    if (!schema_now.kletka[temp.X, temp.Y].Vertical)
                    {
                        kletka[temp.X, temp.Y].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        kletka[temp.X, temp.Y].Refresh();
                        schema_now.kletka[temp.X, temp.Y].Vertical = true;
                    }
                    else
                    {
                        kletka[temp.X, temp.Y].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        kletka[temp.X, temp.Y].Refresh();
                        schema_now.kletka[temp.X, temp.Y].Vertical = false;
                    }
                }
            }
            /*else if (e.ClickedItem.Text == "Копировать")
            {
                copy = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                moveto = false;
                copied = true;
            }
            else if (e.ClickedItem.Text == "Переместить")
            {
                copy = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                moveto = true;
            }
            else if (e.ClickedItem.Text == "Вставить")
            {
                if (copied)
                {
                    Point temp = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                    kletka[temp.X, temp.Y].Name = kletka[copy.X, copy.Y].Name;
                    kletka[temp.X, temp.Y].Image = new Bitmap(kletka[copy.X, copy.Y].Image);
                    kletka[temp.X, temp.Y].Refresh();
                    schema_now.kletka[temp.X, temp.Y] = schema_now.kletka[copy.X, copy.Y];
                }
                else if (moveto)
                {
                    Point temp = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                    kletka[temp.X, temp.Y] = kletka[copy.X, copy.Y];
                    schema_now.kletka[temp.X, temp.Y] = schema_now.kletka[copy.X, copy.Y];
                    kletka[copy.X, copy.Y] = createPictureBox(copy.Y, copy.X);
                    moveto = false;
                }
                else
                    MessageBox.Show("Нечего вставлять", "Ошибка!");
            }*/
        }
        private Point who_clicked_box(object sender)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (sender.Equals(kletka[i, j]))
                        return new Point(i, j);
            return new Point(0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateNewSchem();
        }
    }
}