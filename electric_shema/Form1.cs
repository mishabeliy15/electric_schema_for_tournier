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
        CheckBox[] PropertiesCheckBox;
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
        protected void CreateNewSchem(bool laba)
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
            delete_properties();
            schema_now.Task.Laba = laba;
            groupBox2.Visible = laba;
            i = 0; u = 0; r = 0;valid = false;
            richTextBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            Elemets.Enabled = true;
        }
        public Form1()
        {
            InitializeComponent();
            CreateNewSchem(false);
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
                case "onof":
                    delete_properties();
                    groupBox1.Visible = true;
                    groupBox1.Text = "Свойства рычага [" + i.ToString() + ", " + j.ToString() + "]";
                    PropertiesCheckBox = new CheckBox[1];
                    PropertiesCheckBox[0] = new CheckBox();
                    PropertiesCheckBox[0].Location = new Point(5, 20);
                    PropertiesCheckBox[0].Size = new Size(180, 25);
                    PropertiesCheckBox[0].Text = "Включить";
                    PropertiesCheckBox[0].CheckedChanged += checked_onofChaned;
                    PropertiesCheckBox[0].Checked = schema_now.kletka[i, j].on_of;
                    this.groupBox1.Controls.Add(PropertiesCheckBox[0]);

                    changeable = new Point(i, j);
                    break;
                default:
                    delete_properties();
                    break;
            }
        }
        private void checked_onofChaned(object sender, EventArgs e)
        {
            schema_now.kletka[changeable.X, changeable.Y].on_of = (sender as CheckBox).Checked;
        }
        private void delete_properties()
        {
            if (PropertiesLabels != null && PropertiesTextBox != null)
                for (int i = 0; i < PropertiesLabels.Length; i++)
                {
                    PropertiesLabels[i].Dispose();
                    PropertiesTextBox[i].Dispose();
                }
            if (PropertiesCheckBox != null)
                for (int i = 0; i < PropertiesCheckBox.Length; i++)
                    PropertiesCheckBox[i].Dispose();
            PropertiesLabels = null;
            PropertiesTextBox = null;
            PropertiesCheckBox = null;
            groupBox1.Visible = false;
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
                schema_now.kletka[temp.X, temp.Y] = null;
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
            CreateNewSchem(false);
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                StreamReader se = new StreamReader(openFileDialog1.FileName);
                string s = se.ReadLine();
                schema_json schema_now_convert = JsonConvert.DeserializeObject<schema_json>(s);
                CreateNewSchem(schema_now_convert.Task.Laba);
                schema_now = schema_now_convert;
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
                if (schema_now.Task.Laba)
                {
                    richTextBox1.Text = schema_now.Task.Text;
                    textBox3.Text = schema_now.Task.I.ToString();
                    textBox4.Text = schema_now.Task.U.ToString();
                    textBox5.Text = schema_now.Task.R.ToString();
                    checkBox1.Checked = false;
                    checkBox2.Checked = schema_now.Task.add_elements;
                    Elemets.Enabled = schema_now.Task.add_elements;
                    MessageBox.Show(schema_now.Task.Text,"Задача!");
                }
                se.Close();
            }
            delete_properties();
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
            schema_now.kletka[temp.X, temp.Y].Rotate = schema_now.kletka[copied.X, copied.Y].Rotate;
            schema_now.kletka[temp.X, temp.Y].R = schema_now.kletka[copied.X, copied.Y].R;
            schema_now.kletka[temp.X, temp.Y].U = schema_now.kletka[copied.X, copied.Y].U;
            schema_now.kletka[temp.X, temp.Y].I = schema_now.kletka[copied.X, copied.Y].I;
            if (move)
            {
                kletka[copied.X, copied.Y].Name = null;
                kletka[copied.X, copied.Y].Image = new Bitmap(50, 50);
                if (schema_now.battery == copied) schema_now.battery = temp;
                 schema_now.kletka[copied.X, copied.Y] = new box();
                move = false;
            }
            вставитьToolStripMenuItem.Visible = false;
            show_properties(temp.X, temp.Y);
        }

        double i = 0, u = 0, r = 0;
        bool[,] f;
        bool valid = false;
        bool solved = false;
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
                textBox1.Text = "I = " + (r > 0 ?(i = u / r).ToString():u.ToString()) + "; U = " + u.ToString() + "; R = " + r.ToString(); 
                if(schema_now.Task.Laba)
                {
                    int temp = 0;
                    if (schema_now.Task.I == i) temp += 1;
                    if (schema_now.Task.U == u) temp += 1;
                    if (schema_now.Task.R == r) temp += 1;
                    progressBar1.Value = temp;
                    if (temp == 3)
                    {
                        if (!solved && !checkBox1.Checked) { solved = true; MessageBox.Show("Поздравляем!", "Вы решили задачу!"); }
                    }
                    else solved = false;
                }
            }
            else
            {
                textBox1.Text = "Цепь не замкнута!";
                solved = false;
                if (schema_now.Task.Laba) progressBar1.Value = 0;
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
                            right_dfs(i, j, k);
                            left_dfs(i, j, k);
                            break;
                        case 90:
                            down_dfs(i, j, k);
                            up_dfs(i, j, k);
                            break;
                    }
                else if(schema_now.kletka[i, j].Name == Provod_povorot.Name)//для поворотливых проводов
                    switch (schema_now.kletka[i, j].Rotate)
                    {
                        case 0:
                            down_dfs(i, j, k);
                            left_dfs(i, j, k);
                            break;
                        case 90:
                            up_dfs(i, j, k);
                            left_dfs(i, j, k);
                            break;
                        case 180:
                            up_dfs(i, j, k);
                            right_dfs(i, j, k);
                            break;
                        case 270:
                            down_dfs(i, j, k);
                            right_dfs(i, j, k);
                            break;
                    }
            }
            else return;
        }

        private void up_dfs(int i, int j, int k)
        {
            if (i - 1 > 0 && schema_now.kletka[i - 1, j].Name != "")
                if (!f[i - 1, j] || (new Point(i - 1, j) == schema_now.battery && k > 1))
                    if (schema_now.kletka[i - 1, j].Name != onof.Name || (schema_now.kletka[i - 1, j].on_of))
                    {
                        if ((!isflip(i - 1, j) && turn(i - 1, j, 90)) || (isflip(i - 1, j) && (turn(i - 1, j, 0) || turn(i - 1, j, 270))))
                            if (!f[i - 1, j]) dfs(i - 1, j, k + 1);
                            else if (new Point(i - 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                    }
        }
        private void down_dfs(int i,int j,int k)
        {
            if (i + 1 < 10 && schema_now.kletka[i + 1, j].Name != "")
                if (!f[i + 1, j] || (new Point(i + 1, j) == schema_now.battery && k > 1))
                    if (schema_now.kletka[i + 1, j].Name != onof.Name || (schema_now.kletka[i + 1, j].on_of))
                    {
                        if (turn(i + 1, j, 90) || turn(i + 1, j, 180))
                            if (!f[i + 1, j]) dfs(i + 1, j, k + 1);
                            else if (new Point(i + 1, j) == schema_now.battery && k > 1) { valid = true; return; }
                    }
        }
        private void right_dfs(int i, int j, int k)
        {
            if (j + 1 < 10 && schema_now.kletka[i, j + 1].Name != "")
                if (!f[i, j + 1] || (new Point(i, j + 1) == schema_now.battery && k > 1))
                    if (schema_now.kletka[i, j + 1].Name != onof.Name || (schema_now.kletka[i, j + 1].on_of))
                    {
                        if (turn(i, j + 1, 0) || (isflip(i, j + 1) && turn(i, j + 1, 90)))
                            if (!f[i, j + 1]) dfs(i, j + 1, k + 1);
                            else if (new Point(i, j + 1) == schema_now.battery && k > 1) { valid = true; return; }
                    }
        }
        private void left_dfs(int i, int j, int k)
        {
            if (!f[i, j - 1] || (new Point(i, j - 1) == schema_now.battery && k > 1))
                if (j - 1 > 0 && schema_now.kletka[i, j - 1].Name != "")
                    if (!f[i, j - 1] || (new Point(i, j - 1) == schema_now.battery && k > 1))
                        if (schema_now.kletka[i, j - 1].Name != onof.Name || (schema_now.kletka[i, j - 1].on_of))
                        {
                            if ((!isflip(i, j - 1) && turn(i, j - 1, 0)) || (isflip(i, j - 1) && (turn(i, j - 1, 180) || turn(i, j - 1, 270))))
                                if (!f[i, j - 1]) dfs(i, j - 1, k + 1);
                                else if (new Point(i, j - 1) == schema_now.battery && k > 1) { valid = true; return; }
                        }
        }
        private void создатьЛабароторнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewSchem(true);
            checkBox1.Checked = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double k;
            double.TryParse(textBox3.Text, out k);
            schema_now.Task.I = k;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double k;
            double.TryParse(textBox4.Text, out k);
            schema_now.Task.U = k;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double k;
            double.TryParse(textBox5.Text, out k);
            schema_now.Task.R = k;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            schema_now.Task.Text = richTextBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Enabled = checkBox1.Checked;
            textBox3.Enabled = checkBox1.Checked;
            textBox4.Enabled = checkBox1.Checked;
            textBox5.Enabled = checkBox1.Checked;
            checkBox2.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Elemets.Enabled = checkBox2.Checked;
            schema_now.Task.add_elements = checkBox2.Checked;
        }
    }
}