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
        Label[] PropertiesLabels;
        TextBox[] PropertiesTextBox;
        Point changeable;
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
                        switch (schema_now.kletka[i, j].Name)
                        {
                            case "resistor":
                                delete_properties();
                                groupBox1.Visible = true;
                                groupBox1.Text = "Свойства резистора [" + i.ToString() + ", " + j.ToString() + "]";
                                PropertiesLabels = new Label[1];
                                PropertiesTextBox = new TextBox[1];
                                PropertiesLabels[0] = new Label();
                                PropertiesLabels[0].Location = new Point(5, 20);
                                PropertiesLabels[0].Size = new Size(180, 25);
                                PropertiesLabels[0].Text = "Сопротивление (R, Ом):";
                                this.groupBox1.Controls.Add(PropertiesLabels[0]);

                                PropertiesTextBox[0] = new TextBox();
                                PropertiesTextBox[0].Name = "Opir";
                                PropertiesTextBox[0].Location = new Point(185, 20);
                                PropertiesTextBox[0].Size = new Size(65, 25);
                                PropertiesTextBox[0].Text = (schema_now.kletka[i, j].Properties as Resistor).R.ToString();
                                PropertiesTextBox[0].KeyPress += textBox_KeyPress;
                                PropertiesTextBox[0].TextChanged += textBox_TextChanged;
                                this.groupBox1.Controls.Add(PropertiesTextBox[0]);

                                changeable = new Point(i, j);
                                break;
                            case "battery":
                                delete_properties();
                                groupBox1.Visible = true;
                                groupBox1.Text = "Свойства батареи [" + i.ToString() + ", " + j.ToString() + "]";
                                PropertiesLabels = new Label[1];
                                PropertiesTextBox = new TextBox[1];
                                PropertiesLabels[0] = new Label();
                                PropertiesLabels[0].Location = new Point(5, 20);
                                PropertiesLabels[0].Size = new Size(180, 25);
                                PropertiesLabels[0].Text = "Напряжения (U, Вольт):";
                                this.groupBox1.Controls.Add(PropertiesLabels[0]);

                                PropertiesTextBox[0] = new TextBox();
                                PropertiesTextBox[0].Name = "Napruga";
                                PropertiesTextBox[0].Location = new Point(185, 20);
                                PropertiesTextBox[0].Size = new Size(65, 25);
                                PropertiesTextBox[0].Text = (schema_now.kletka[i, j].Properties as Battery).U.ToString();
                                PropertiesTextBox[0].KeyPress += textBox_KeyPress;
                                PropertiesTextBox[0].TextChanged += textBox_TextChanged;
                                this.groupBox1.Controls.Add(PropertiesTextBox[0]);

                                changeable = new Point(i, j);
                                break;
                            default:
                                delete_properties();
                                break;
                        }
                        break;
                    }
        }
        private void delete_properties()
        {
            if (PropertiesLabels != null && PropertiesTextBox!=null)
            {
                for (int i = 0; i < PropertiesLabels.Length; i++)
                {
                    PropertiesLabels[i].Dispose();
                    PropertiesTextBox[i].Dispose();
                }
                PropertiesLabels = null;
                PropertiesTextBox = null;
                groupBox1.Visible = false;
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
                e.Handled = true;
            else if(e.KeyChar == ',' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            double k;
            if (double.TryParse((sender as TextBox).Text, out k))
            {
                switch (schema_now.kletka[changeable.X, changeable.Y].Name)
                {
                    case "resistor":
                        (schema_now.kletka[changeable.X, changeable.Y].Properties as Resistor).R = k;
                        break;
                    case "battery":
                        (schema_now.kletka[changeable.X, changeable.Y].Properties as Battery).U = k;
                        break;
                    default:
                        break;
                }
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
                schema_now.kletka[i, j].Properties = new Battery();
                (schema_now.kletka[i, j].Properties as Battery).U = 12;
                return battery;
            }
            else if (radioButton3.Checked) return voltmetr;
            else if (radioButton4.Checked)
            {
                schema_now.kletka[i, j].Properties = new Ampermetr();
                (schema_now.kletka[i, j].Properties as Ampermetr).I = 0;
                return ampmetr;
            }
            else if (radioButton5.Checked) return onof;
            else if (radioButton6.Checked) return Lampa;
            else if (radioButton7.Checked) return Provod;
            else return null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
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
                CreateNewSchem();
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