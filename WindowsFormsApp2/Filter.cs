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
        public Button button2;
        public pers(int part1, string name1)
        {
            part = part1;
            name = name1;
            button2 = new Button();
        }
    }

    public partial class Filter : Form
    {
        pers[] lydi = new pers[5];
        public Filter()
        {
            InitializeComponent();
            lydi[0] = new pers(1, "Сидор");
            lydi[1] = new pers(2, "Шустрый");
            lydi[2] = new pers(3, "Меченый");
            lydi[3] = new pers(4, "Стрелок");
            lydi[4] = new pers(5, "Шрам");
            lydi[5] = new pers(6, "Шакал");
            lydi[6] = new pers(7, "Чёрный");
            lydi[7] = new pers(8, "Дегтярёв");
            lydi[8] = new pers(9, "Йога");
            lydi[9] = new pers(10, "Зулус");
            lydi[10] = new pers(11, "Соколов");
            lydi[11] = new pers(12, "Ковальский");


            int x = 0;
            for (int i = 0; i < lydi.Length; i++)
            {
                lydi[i].button2.Location = new Point(x, 60);
                lydi[i].button2.Size = new Size(290, 40);
                lydi[i].button2.Text = lydi[i].name;
                lydi[i].button2.Click += new EventHandler(button2_Click);
                Controls.Add(lydi[i].button2);
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
            Person f = new Person();
            f.Show();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}  