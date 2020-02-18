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

    public partial class Form2 : Form
    {
        pers[] lydi = new pers[100];
        public Form2()
        {
            InitializeComponent();
            lydi[0] = new pers(1, "Сидор");
            lydi[1] = new pers(2, "Шустрый");
            lydi[2] = new pers(3, "Меченый");

            for (int i = 0; i < 3; i++)
            {
                lydi[i].button2.Location = new Point(340, 40);
                lydi[i].button2.Size = new Size(290, 40);
                lydi[i].button2.Text = lydi[i].name;
                Controls.Add(lydi[i].button2);
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
              for(int i = 0; i < 3; i++)
               {
                if (lydi[i].part < Convert.ToInt32(button1.Text))
                {

                }
              }
        }
                                                                                                                                      

    }
}  