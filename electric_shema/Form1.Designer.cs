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
            this.Provod_povorot = new System.Windows.Forms.PictureBox();
            this.Provod = new System.Windows.Forms.PictureBox();
            this.Lampa = new System.Windows.Forms.PictureBox();
            this.onof = new System.Windows.Forms.PictureBox();
            this.ampmetr = new System.Windows.Forms.PictureBox();
            this.voltmetr = new System.Windows.Forms.PictureBox();
            this.battery = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.перевернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.resistor)).BeginInit();
            this.Elemets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Provod_povorot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Provod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lampa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampmetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltmetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battery)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Schema
            // 
            this.Schema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Schema.Location = new System.Drawing.Point(144, 31);
            this.Schema.Name = "Schema";
            this.Schema.Size = new System.Drawing.Size(668, 618);
            this.Schema.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            // 
            // resistor
            // 
            this.resistor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resistor.Image = ((System.Drawing.Image)(resources.GetObject("resistor.Image")));
            this.resistor.Location = new System.Drawing.Point(6, 21);
            this.resistor.Name = "resistor";
            this.resistor.Size = new System.Drawing.Size(117, 69);
            this.resistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resistor.TabIndex = 3;
            this.resistor.TabStop = false;
            this.resistor.Click += new System.EventHandler(this.resistor_Click);
            // 
            // Elemets
            // 
            this.Elemets.Controls.Add(this.Provod_povorot);
            this.Elemets.Controls.Add(this.Provod);
            this.Elemets.Controls.Add(this.Lampa);
            this.Elemets.Controls.Add(this.onof);
            this.Elemets.Controls.Add(this.ampmetr);
            this.Elemets.Controls.Add(this.voltmetr);
            this.Elemets.Controls.Add(this.battery);
            this.Elemets.Controls.Add(this.resistor);
            this.Elemets.Location = new System.Drawing.Point(9, 31);
            this.Elemets.Name = "Elemets";
            this.Elemets.Size = new System.Drawing.Size(129, 618);
            this.Elemets.TabIndex = 9;
            this.Elemets.TabStop = false;
            this.Elemets.Text = "Элементы схемы";
            // 
            // Provod_povorot
            // 
            this.Provod_povorot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Provod_povorot.Image = ((System.Drawing.Image)(resources.GetObject("Provod_povorot.Image")));
            this.Provod_povorot.Location = new System.Drawing.Point(6, 543);
            this.Provod_povorot.Name = "Provod_povorot";
            this.Provod_povorot.Size = new System.Drawing.Size(117, 69);
            this.Provod_povorot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Provod_povorot.TabIndex = 22;
            this.Provod_povorot.TabStop = false;
            this.Provod_povorot.Click += new System.EventHandler(this.Provod_povorot_Click);
            // 
            // Provod
            // 
            this.Provod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Provod.Image = ((System.Drawing.Image)(resources.GetObject("Provod.Image")));
            this.Provod.Location = new System.Drawing.Point(6, 471);
            this.Provod.Name = "Provod";
            this.Provod.Size = new System.Drawing.Size(117, 69);
            this.Provod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Provod.TabIndex = 20;
            this.Provod.TabStop = false;
            this.Provod.Click += new System.EventHandler(this.Provod_Click);
            // 
            // Lampa
            // 
            this.Lampa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lampa.Image = ((System.Drawing.Image)(resources.GetObject("Lampa.Image")));
            this.Lampa.Location = new System.Drawing.Point(6, 396);
            this.Lampa.Name = "Lampa";
            this.Lampa.Size = new System.Drawing.Size(117, 69);
            this.Lampa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lampa.TabIndex = 19;
            this.Lampa.TabStop = false;
            this.Lampa.Click += new System.EventHandler(this.Lampa_Click);
            // 
            // onof
            // 
            this.onof.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onof.Image = ((System.Drawing.Image)(resources.GetObject("onof.Image")));
            this.onof.Location = new System.Drawing.Point(6, 321);
            this.onof.Name = "onof";
            this.onof.Size = new System.Drawing.Size(117, 69);
            this.onof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.onof.TabIndex = 15;
            this.onof.TabStop = false;
            this.onof.Click += new System.EventHandler(this.onof_Click);
            // 
            // ampmetr
            // 
            this.ampmetr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ampmetr.Image = ((System.Drawing.Image)(resources.GetObject("ampmetr.Image")));
            this.ampmetr.Location = new System.Drawing.Point(6, 246);
            this.ampmetr.Name = "ampmetr";
            this.ampmetr.Size = new System.Drawing.Size(117, 69);
            this.ampmetr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ampmetr.TabIndex = 13;
            this.ampmetr.TabStop = false;
            this.ampmetr.Click += new System.EventHandler(this.ampmetr_Click);
            // 
            // voltmetr
            // 
            this.voltmetr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voltmetr.Image = ((System.Drawing.Image)(resources.GetObject("voltmetr.Image")));
            this.voltmetr.Location = new System.Drawing.Point(6, 171);
            this.voltmetr.Name = "voltmetr";
            this.voltmetr.Size = new System.Drawing.Size(117, 69);
            this.voltmetr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.voltmetr.TabIndex = 11;
            this.voltmetr.TabStop = false;
            this.voltmetr.Click += new System.EventHandler(this.voltmetr_Click);
            // 
            // battery
            // 
            this.battery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.battery.Image = ((System.Drawing.Image)(resources.GetObject("battery.Image")));
            this.battery.Location = new System.Drawing.Point(6, 96);
            this.battery.Name = "battery";
            this.battery.Size = new System.Drawing.Size(117, 69);
            this.battery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.battery.TabIndex = 10;
            this.battery.TabStop = false;
            this.battery.Click += new System.EventHandler(this.battery_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перевернутьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 152);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // перевернутьToolStripMenuItem
            // 
            this.перевернутьToolStripMenuItem.Name = "перевернутьToolStripMenuItem";
            this.перевернутьToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.перевернутьToolStripMenuItem.Text = "Повернуть";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(818, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 618);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            this.groupBox1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Visible = false;
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 655);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Elemets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Schema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Электрические цепи";
            ((System.ComponentModel.ISupportInitialize)(this.resistor)).EndInit();
            this.Elemets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Provod_povorot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Provod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lampa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampmetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltmetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battery)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Schema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox resistor;
        private System.Windows.Forms.GroupBox Elemets;
        private System.Windows.Forms.PictureBox battery;
        private System.Windows.Forms.PictureBox ampmetr;
        private System.Windows.Forms.PictureBox voltmetr;
        private System.Windows.Forms.PictureBox onof;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox Provod;
        private System.Windows.Forms.PictureBox Lampa;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевернутьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Provod_povorot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
    }
}

