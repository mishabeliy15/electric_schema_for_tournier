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
        PictureBox NewElements;
        Point copied;
        bool move = false;
        private PictureBox createPictureBox(int x, int y)
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
            timer1.Start();
        }
        private void picture_click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (sender.Equals(kletka[i, j]))
                    {
                        if (this.Cursor == System.Windows.Forms.Cursors.Hand)
                        {
                            kletka[i, j].Image = new Bitmap(NewElements.Image);
                            kletka[i, j].Name = NewElements.Name;
                            schema_now.kletka[i, j].Name = NewElements.Name;
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                        }
                        show_properties(i, j);
                        break;
                    }
        }
        private void show_properties(int i, int j)
        {
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
                    PropertiesTextBox[0].Text = schema_now.kletka[i, j].R.ToString();
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
                    PropertiesTextBox[0].Text = schema_now.kletka[i, j].U.ToString();
                    PropertiesTextBox[0].KeyPress += textBox_KeyPress;
                    PropertiesTextBox[0].TextChanged += textBox_TextChanged;
                    this.groupBox1.Controls.Add(PropertiesTextBox[0]);

                    changeable = new Point(i, j);
                    break;
                default:
                    delete_properties();
                    break;
            }
        }
        private void delete_properties()
        {
            if (PropertiesLabels != null && PropertiesTextBox != null)
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
            else if (e.KeyChar == ',' && (sender as TextBox).Text.Contains("."))
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
                        schema_now.kletka[changeable.X, changeable.Y].R = k;
                        break;
                    case "battery":
                        schema_now.kletka[changeable.X, changeable.Y].U = k;
                        break;
                    default:
                        break;
                }
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
            else if (name == Provod_povorot.Name)
                return Provod_povorot;
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
            else if (e.ClickedItem.Text == "Повернуть")
            {
                if ((contextMenuStrip1.SourceControl as PictureBox).Image != null)
                {
                    Point temp = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                    if (schema_now.kletka[temp.X, temp.Y].Name != Provod_povorot.Name)
                    {
                        if (schema_now.kletka[temp.X, temp.Y].Rotate == 0)
                        {
                            kletka[temp.X, temp.Y].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            kletka[temp.X, temp.Y].Refresh();
                            schema_now.kletka[temp.X, temp.Y].Rotate = 90;
                        }
                        else
                        {
                            kletka[temp.X, temp.Y].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            kletka[temp.X, temp.Y].Refresh();
                            schema_now.kletka[temp.X, temp.Y].Rotate = 0;
                        }
                    }
                    else
                    {
                        kletka[temp.X, temp.Y].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        kletka[temp.X, temp.Y].Refresh();
                        schema_now.kletka[temp.X, temp.Y].Rotate += 90;
                        schema_now.kletka[temp.X, temp.Y].Rotate %= 360;
                    }
                }
            }
        }
        private Point who_clicked_box(object sender)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (sender.Equals(kletka[i, j]))
                        return new Point(i, j);
            return new Point(0, 0);
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewSchem();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
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
                            kletka[i, j].Image = new Bitmap(who_name(schema_now.kletka[i, j].Name).Image);
                            kletka[i, j].Name = schema_now.kletka[i, j].Name;
                            switch (schema_now.kletka[i, j].Rotate)
                            {
                                case 90:
                                    kletka[i, j].Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                                    kletka[i, j].Refresh();
                                    break;
                                case 180:
                                    kletka[i, j].Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                                    kletka[i, j].Refresh();
                                    break;
                                case 270:
                                    kletka[i, j].Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                    kletka[i, j].Refresh();
                                    break;
                                default:
                                    kletka[i, j].Refresh();
                                    break;
                            }

                        }
                        else
                            kletka[i, j].Image = new Bitmap(50, 50);
                se.Close();
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(JsonConvert.SerializeObject(schema_now));
                sw.Close();
            }
        }

        private void resistor_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = resistor;
        }

        private void battery_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = battery;
        }

        private void voltmetr_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = voltmetr;
        }

        private void ampmetr_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = ampmetr;
        }

        private void onof_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = onof;
        }

        private void Lampa_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = Lampa;
        }

        private void Provod_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = Provod;
        }

        private void Provod_povorot_Click(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            delete_properties();
            NewElements = Provod_povorot;
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((contextMenuStrip1.SourceControl as PictureBox).Image == null)
                MessageBox.Show("Нечего вырезать", "Ошибка!");
            else
            {
                copied = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                move = true;
                вставитьToolStripMenuItem.Visible = true;
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((contextMenuStrip1.SourceControl as PictureBox).Image == null)
                MessageBox.Show("Нечего копировать", "Ошибка!");
            else
            {
                copied = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
                move = false;
                вставитьToolStripMenuItem.Visible = true;
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point temp = who_clicked_box(contextMenuStrip1.SourceControl as PictureBox);
            kletka[temp.X, temp.Y].Name = kletka[copied.X, copied.Y].Name;
            kletka[temp.X, temp.Y].Image = new Bitmap(kletka[copied.X, copied.Y].Image);
            schema_now.kletka[temp.X, temp.Y].Name = schema_now.kletka[copied.X, copied.Y].Name;
            schema_now.kletka[temp.X, temp.Y].R = schema_now.kletka[copied.X, copied.Y].R;
            schema_now.kletka[temp.X, temp.Y].Rotate = schema_now.kletka[copied.X, copied.Y].Rotate;
            schema_now.kletka[temp.X, temp.Y].U = schema_now.kletka[copied.X, copied.Y].U;
            if (move)
            {
                kletka[copied.X, copied.Y].Name = null;
                kletka[copied.X, copied.Y].Image = new Bitmap(50, 50);
                schema_now.kletka[copied.X, copied.Y] = new box();
                move = false;
            }
            вставитьToolStripMenuItem.Visible = false;
            show_properties(temp.X, temp.Y);
        }

        double i = 0, u = 0, r = 0;
        bool[,] f;
        bool valid = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!schema_now.power)
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        if (schema_now.kletka[i, j].Name == battery.Name)
                        {
                            schema_now.power = true;
                            schema_now.battery = new Point(i, j);
                        }
            if (schema_now.power)
            {
                i = 0; u = 0; r = 0; f = new bool[10, 10]; valid = false;
                for (int i = 0; i < 10; i++) for (int j = 0; j < 10; j++) f[i, j] = false;
                dfs(schema_now.battery.X, schema_now.battery.Y, 0);
            }
            if (valid)
            {
                 textBox1.Text = "I = " + (r > 0 ?(i = u / r).ToString():"Деление на 0!") + "; U = " + u.ToString() + "; R = " + r.ToString(); 
            }
        }
        private bool isflip(int i,int j){ return schema_now.kletka[i, j].Name == Provod_povorot.Name; }

        private bool turn(int i, int j, int Angle) { return schema_now.kletka[i, j].Rotate == Angle; }

        private void dfs(int i,int j,int k)
        {
            if (!valid)
            {
                f[i, j] = true;
                if (schema_now.kletka[i, j].Name == battery.Name)
                {
                    u += schema_now.kletka[i, j].U;
                }
                else if (schema_now.kletka[i, j].Name == resistor.Name)
                {
                    r += schema_now.kletka[i, j].R;
                };

                if (!isflip(i,j))
                    switch (schema_now.kletka[i, j].Rotate)
                    {
                        case 0:
                            if (j + 1 < 10)
                            {
                                if (turn(i, j + 1, 0) || (isflip(i, j + 1) && turn(i, j + 1, 90)))
                                    if (!f[i, j + 1]) dfs(i, j + 1, k + 1);
                                    else if (new Point(i, j + 1) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            if (j - 1 > 0)
                            {
                                if ((!isflip(i, j - 1) && turn(i, j - 1, 0)) || (isflip(i, j - 1) && (turn(i, j - 1, 180) || turn(i, j - 1, 270))))
                                    if (!f[i, j - 1]) dfs(i, j - 1, k + 1);
                                    else if (new Point(i, j - 1) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            break;
                        case 90:
                            if (i + 1 < 10)
                            {
                                if (turn(i + 1, j, 90) || turn(i + 1, j, 180))
                                    if (!f[i + 1, j]) dfs(i + 1, j, k + 1);
                                    else if (new Point(i + 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            if (i - 1 > 0)
                            {
                                if ( (!isflip(i-1,j) && turn(i - 1, j, 90)) || (isflip(i-1,j)&&(turn(i-1,j,0)||turn(i-1,j,270))))
                                    if (!f[i - 1, j]) dfs(i - 1, j, k + 1);
                                    else if (new Point(i - 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            break;
                    }
                else if(schema_now.kletka[i, j].Name == Provod_povorot.Name)//для поворотливых проводов
                    switch (schema_now.kletka[i, j].Rotate)
                    {
                        case 0:
                            if (i + 1 < 10)
                            {
                                if (turn(i + 1, j, 90) || turn(i + 1, j, 180))
                                    if (!f[i + 1, j]) dfs(i + 1, j, k + 1);
                                    else if (new Point(i + 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            if (j - 1 > 0)
                            {
                                if ((!isflip(i, j - 1) && turn(i, j - 1, 0)) || (isflip(i, j - 1) && (turn(i, j - 1, 180) || turn(i, j - 1, 270))))
                                    if (!f[i, j - 1]) dfs(i, j - 1, k + 1);
                                    else if (new Point(i, j - 1) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            break;
                        case 90:
                            if (i - 1 > 0)
                            {
                                if ((!isflip(i - 1, j) && turn(i - 1, j, 90)) || (isflip(i - 1, j) && (turn(i - 1, j, 0) || turn(i - 1, j, 270))))
                                    if (!f[i - 1, j]) dfs(i - 1, j, k + 1);
                                    else if (new Point(i - 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            if (j - 1 > 0)
                            {
                                if ((!isflip(i, j - 1) && turn(i, j - 1, 0)) || (isflip(i, j - 1) && (turn(i, j - 1, 180) || turn(i, j - 1, 270))))
                                    if (!f[i, j - 1]) dfs(i, j - 1, k + 1);
                                    else if (new Point(i, j - 1) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            break;
                        case 180:
                            if (i - 1 > 0)
                            {
                                if ((!isflip(i - 1, j) && turn(i - 1, j, 90)) || (isflip(i - 1, j) && (turn(i - 1, j, 0) || turn(i - 1, j, 270))))
                                    if (!f[i - 1, j]) dfs(i - 1, j, k + 1);
                                    else if (new Point(i - 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            if (j + 1 < 10)
                            {
                                if (turn(i, j + 1, 0) || (isflip(i, j + 1) && turn(i, j + 1, 90)))
                                    if (!f[i, j + 1]) dfs(i, j + 1, k + 1);
                                    else if (new Point(i, j + 1) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            break;
                        case 270:
                            if (i + 1 < 10)
                            {
                                if (turn(i + 1, j, 90) || turn(i + 1, j, 180))
                                    if (!f[i + 1, j]) dfs(i + 1, j, k + 1);
                                    else if (new Point(i + 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            if (j + 1 < 10)
                            {
                                if (turn(i, j + 1, 0) || (isflip(i, j + 1) && turn(i, j + 1, 90)))
                                    if (!f[i, j + 1]) dfs(i, j + 1, k + 1);
                                    else if (new Point(i, j + 1) == schema_now.battery && k > 1) { valid = true; return; }
                            }
                            break;
                    }
            }
            else return;
        }
    }
}