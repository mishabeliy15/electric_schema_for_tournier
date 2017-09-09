namespace electric_shema
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Schema = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.resistor = new System.Windows.Forms.PictureBox();
            this.Elemets = new System.Windows.Forms.GroupBox();
            this.Provod = new System.Windows.Forms.PictureBox();
            this.Lampa = new System.Windows.Forms.PictureBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.onof = new System.Windows.Forms.PictureBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.ampmetr = new System.Windows.Forms.PictureBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.voltmetr = new System.Windows.Forms.PictureBox();
            this.battery = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.перевернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resistor)).BeginInit();
            this.Elemets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Provod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lampa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampmetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltmetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battery)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Schema
            // 
            this.Schema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Schema.Location = new System.Drawing.Point(170, 41);
            this.Schema.Name = "Schema";
            this.Schema.Size = new System.Drawing.Size(668, 618);
            this.Schema.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // resistor
            // 
            this.resistor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resistor.Image = ((System.Drawing.Image)(resources.GetObject("resistor.Image")));
            this.resistor.Location = new System.Drawing.Point(29, 21);
            this.resistor.Name = "resistor";
            this.resistor.Size = new System.Drawing.Size(117, 69);
            this.resistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resistor.TabIndex = 3;
            this.resistor.TabStop = false;
            // 
            // Elemets
            // 
            this.Elemets.Controls.Add(this.Provod);
            this.Elemets.Controls.Add(this.Lampa);
            this.Elemets.Controls.Add(this.radioButton7);
            this.Elemets.Controls.Add(this.radioButton6);
            this.Elemets.Controls.Add(this.radioButton5);
            this.Elemets.Controls.Add(this.onof);
            this.Elemets.Controls.Add(this.radioButton4);
            this.Elemets.Controls.Add(this.ampmetr);
            this.Elemets.Controls.Add(this.radioButton3);
            this.Elemets.Controls.Add(this.voltmetr);
            this.Elemets.Controls.Add(this.battery);
            this.Elemets.Controls.Add(this.radioButton2);
            this.Elemets.Controls.Add(this.radioButton1);
            this.Elemets.Controls.Add(this.resistor);
            this.Elemets.Location = new System.Drawing.Point(12, 41);
            this.Elemets.Name = "Elemets";
            this.Elemets.Size = new System.Drawing.Size(152, 618);
            this.Elemets.TabIndex = 9;
            this.Elemets.TabStop = false;
            this.Elemets.Text = "Элементы схемы";
            // 
            // Provod
            // 
            this.Provod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Provod.Image = ((System.Drawing.Image)(resources.GetObject("Provod.Image")));
            this.Provod.Location = new System.Drawing.Point(29, 471);
            this.Provod.Name = "Provod";
            this.Provod.Size = new System.Drawing.Size(117, 69);
            this.Provod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Provod.TabIndex = 20;
            this.Provod.TabStop = false;
            // 
            // Lampa
            // 
            this.Lampa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lampa.Image = ((System.Drawing.Image)(resources.GetObject("Lampa.Image")));
            this.Lampa.Location = new System.Drawing.Point(29, 396);
            this.Lampa.Name = "Lampa";
            this.Lampa.Size = new System.Drawing.Size(117, 69);
            this.Lampa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lampa.TabIndex = 19;
            this.Lampa.TabStop = false;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 496);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(17, 16);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 421);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(17, 16);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 347);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(17, 16);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // onof
            // 
            this.onof.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onof.Image = ((System.Drawing.Image)(resources.GetObject("onof.Image")));
            this.onof.Location = new System.Drawing.Point(29, 321);
            this.onof.Name = "onof";
            this.onof.Size = new System.Drawing.Size(117, 69);
            this.onof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onof.TabIndex = 15;
            this.onof.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 270);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 16);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // ampmetr
            // 
            this.ampmetr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ampmetr.Image = ((System.Drawing.Image)(resources.GetObject("ampmetr.Image")));
            this.ampmetr.Location = new System.Drawing.Point(29, 246);
            this.ampmetr.Name = "ampmetr";
            this.ampmetr.Size = new System.Drawing.Size(117, 69);
            this.ampmetr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ampmetr.TabIndex = 13;
            this.ampmetr.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 195);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // voltmetr
            // 
            this.voltmetr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voltmetr.Image = ((System.Drawing.Image)(resources.GetObject("voltmetr.Image")));
            this.voltmetr.Location = new System.Drawing.Point(29, 171);
            this.voltmetr.Name = "voltmetr";
            this.voltmetr.Size = new System.Drawing.Size(117, 69);
            this.voltmetr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.voltmetr.TabIndex = 11;
            this.voltmetr.TabStop = false;
            // 
            // battery
            // 
            this.battery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battery.Image = ((System.Drawing.Image)(resources.GetObject("battery.Image")));
            this.battery.Location = new System.Drawing.Point(29, 96);
            this.battery.Name = "battery";
            this.battery.Size = new System.Drawing.Size(117, 69);
            this.battery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.battery.TabIndex = 10;
            this.battery.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 121);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JSON|*.json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JSON|*.json";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сохранить схему";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(575, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Открыть схему";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перевернутьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 52);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // перевернутьToolStripMenuItem
            // 
            this.перевернутьToolStripMenuItem.Name = "перевернутьToolStripMenuItem";
            this.перевернутьToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.перевернутьToolStripMenuItem.Text = "Перевернуть";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Новую схему";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(844, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 618);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(97, 589);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Изменить (Сохранить)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Elemets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Schema);
            this.Name = "Form1";
            this.Text = "Цепи [BETA]";
            ((System.ComponentModel.ISupportInitialize)(this.resistor)).EndInit();
            this.Elemets.ResumeLayout(false);
            this.Elemets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Provod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lampa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampmetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltmetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battery)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Schema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox resistor;
        private System.Windows.Forms.GroupBox Elemets;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox battery;
        private System.Windows.Forms.PictureBox ampmetr;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox voltmetr;
        private System.Windows.Forms.PictureBox onof;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox Provod;
        private System.Windows.Forms.PictureBox Lampa;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевернутьToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
    }
}

