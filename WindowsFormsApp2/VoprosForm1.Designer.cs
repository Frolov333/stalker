namespace WindowsFormsApp2
{
    partial class VoprosForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoprosForm1));
            this.button1 = new System.Windows.Forms.Button();
            this.otvet1 = new System.Windows.Forms.Button();
            this.otvet2 = new System.Windows.Forms.Button();
            this.otvet3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(745, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "кто это?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // otvet1
            // 
            this.otvet1.Location = new System.Drawing.Point(48, 399);
            this.otvet1.Name = "otvet1";
            this.otvet1.Size = new System.Drawing.Size(140, 39);
            this.otvet1.TabIndex = 2;
            this.otvet1.Text = "Николай";
            this.otvet1.UseVisualStyleBackColor = true;
            this.otvet1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // otvet2
            // 
            this.otvet2.Location = new System.Drawing.Point(268, 399);
            this.otvet2.Name = "otvet2";
            this.otvet2.Size = new System.Drawing.Size(126, 39);
            this.otvet2.TabIndex = 3;
            this.otvet2.Text = "Ярик";
            this.otvet2.UseVisualStyleBackColor = true;
            this.otvet2.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // otvet3
            // 
            this.otvet3.Location = new System.Drawing.Point(547, 395);
            this.otvet3.Name = "otvet3";
            this.otvet3.Size = new System.Drawing.Size(140, 42);
            this.otvet3.TabIndex = 4;
            this.otvet3.Text = "Сидор";
            this.otvet3.UseVisualStyleBackColor = true;
            this.otvet3.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(745, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(48, 83);
            this.button5.TabIndex = 11;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // VoprosForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 474);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.otvet3);
            this.Controls.Add(this.otvet2);
            this.Controls.Add(this.otvet1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VoprosForm1";
            this.Text = "vopros1";
            this.Load += new System.EventHandler(this.VoprosForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button otvet1;
        private System.Windows.Forms.Button otvet2;
        private System.Windows.Forms.Button otvet3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
    }
}

