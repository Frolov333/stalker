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
        public string adress;
        public pers(int part1, string name1, string role1, string adress1)
        {
            part = part1;
            name = name1;
            role = role1;
            button2 = new Button();
            pictureBox1 = new PictureBox();
            adress = adress1;

        }
    }

 //   Dictionary<string, string> RusWords = new Dictionary<string, string>();
//    Dictionary<string, string> EnWords = new Dictionary<string, string>();

    public partial class Filter : Form
    {
       List<pers> lydi = new List <pers>();
        public Filter()
        {

            string[] lines = System.IO.File.ReadAllLines("Персонажи.txt");
            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                pers pers1 = new pers(Convert.ToInt32(parts[0]), parts[1], (parts[2]), parts[3]);
               lydi.Add(pers1);
            }

            InitializeComponent();
            
            int x = 0;
            int y = 100;
            for (int i = 0; i < lydi.Count; i++)
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

             /*   RusWords.Add("Часть", "Часть");
                RusWords.Add("Имя", "Имя");
                RusWords.Add("Роль", "Роль");

                EnWords.Add("Часть", "Part");
                EnWords.Add("Имя", "Name");
                EnWords.Add("Роль", "Role");
                */
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lydi.Count; i++)
            {
                lydi[i].button2.Visible = true;
                lydi[i].pictureBox1.Visible = true;
                //Совпадение имени
                if (textBox2.Text != "" &&
                    !lydi[i].name.Contains(textBox2.Text))
                {
                    lydi[i].button2.Visible = false;
                    lydi[i].pictureBox1.Visible = false;            
                }

                //проверка части
                if (textBox1.Text != "" &&
                    lydi[i].part != Convert.ToInt32(textBox1.Text))
                {
                    lydi[i].button2.Visible = false;
                    lydi[i].pictureBox1.Visible = false;

                }

                //проверка роли
                if (comboBox1.Text != "" &&
                    lydi[i].role != (comboBox1.Text))
                {
                    lydi[i].button2.Visible = false;
                    lydi[i].pictureBox1.Visible = false;

                }
            }
        }
                                   

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lydi.Count; i++)
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

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}  