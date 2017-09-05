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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Schema = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.resistor = new System.Windows.Forms.PictureBox();
            this.Elemets = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.battery = new System.Windows.Forms.PictureBox();
            this.voltmetr = new System.Windows.Forms.PictureBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.ampmetr = new System.Windows.Forms.PictureBox();
            this.onof = new System.Windows.Forms.PictureBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resistor)).BeginInit();
            this.Elemets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.battery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltmetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampmetr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onof)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(27, 12);
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
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 195);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.UseVisualStyleBackColor = true;
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
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 347);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(17, 16);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.UseVisualStyleBackColor = true;
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
            this.button2.Location = new System.Drawing.Point(258, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Сохранить схему";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Открыть схему";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 696);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Elemets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Schema);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resistor)).EndInit();
            this.Elemets.ResumeLayout(false);
            this.Elemets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.battery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltmetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampmetr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onof)).EndInit();
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
    }
}

