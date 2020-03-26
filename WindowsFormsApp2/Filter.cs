using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public struct pers
    {
        public int part;
        public string name;
        public string role;
        public Button button2;
        public PictureBox pictureBox1;
        public pers(int part1, string name1, string role1)
        {
            part = part1;
            name = name1;
            role = role1;
            button2 = new Button();
            pictureBox1 = new PictureBox();
        }
    }

    public partial class Filter : Form
    {
        pers[] lydi = new pers[17];
        public Filter()
        {
            InitializeComponent();
            lydi[0] = new pers(1, "Сидор", "Положительная");
            lydi[1] = new pers(2, "Шустрый", "Нейтральная");
            lydi[2] = new pers(1, "Меченый", "Положительная");
            lydi[3] = new pers(2, "Стрелок", "Положительная");
            lydi[4] = new pers(2, "Шрам", "Отрицательная");
            lydi[5] = new pers(3, "Шакал","Отрицательная");
            lydi[6] = new pers(3, "Чёрный", "Отрицательная");
            lydi[7] = new pers(3, "Дегтярёв","Положительная");
            lydi[8] = new pers(2, "Йога","Отрицательная");
            lydi[9] = new pers(3, "Зулус", "Положительная");
            lydi[10] = new pers(3, "Соколов", "Положительная");
            lydi[11] = new pers(3, "Ковальский", "Положительная");
            lydi[12] = new pers(3, "Флинт", "Отрицательная");
            lydi[13] = new pers(3, "Локи", "Нейтральная");
            lydi[14] = new pers(3, "Шульга", "Нейтральная");
            lydi[15] = new pers(3, "Вано", "Положительная");
            lydi[16] = new pers(2, "Чехов", "Нейтральная");


            int x = 0;
            int y = 100;
            for (int i = 0; i < lydi.Length; i++)
            {
                lydi[i].button2.Location = new Point(x, y);
                lydi[i].button2.Size = new Size(100, 40);
                lydi[i].button2.Text = lydi[i].name;
                lydi[i].button2.Click += new EventHandler(button2_Click);
                Controls.Add(lydi[i].button2);

                try
                {
                    lydi[i].pictureBox1.Location = new Point(x, y + 40);
                    lydi[i].pictureBox1.Size = new Size(100, 60);
                    lydi[i].pictureBox1.Text = lydi[i].name;
                    lydi[i].pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    lydi[i].pictureBox1.Load("../../Kartinki/" + lydi[i].name + ".jpg");
                    Controls.Add(lydi[i].pictureBox1);
                }
                catch (Exception) { }



                x = x + 100;
                if (x + 100 > Width)
                {
                    x = 0;
                    y = y + 100;
                }
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lydi.Length; i++)
            {
                lydi[i].button2.Visible = true;
                if (textBox1.Text != "" &&
                    lydi[i].part != Convert.ToInt32(textBox1.Text))
                {
                    lydi[i].button2.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lydi.Length; i++)
            {
                if (sender == lydi[i].button2)
                { 
                   Person f = new Person(lydi[i]);
                   f.Show();
                }
            }
            

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}  