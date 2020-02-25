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

    public partial class VoprosForm1 : Form
    {

        int nomerVoprosa = 1;
        public VoprosForm1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спасибо, бро");
        }

        void drawPic(string text)
        {
            try
            {
                button1.Text = text;
                pictureBox1.Load("../../Kartinki/" + text + ".jpg");
                string[] stroki = System.IO.File.ReadAllLines("../../Kartinki/" + text + ".txt");

                Button[] btn = new Button[3];
                btn[0] = otvet1;
                btn[1] = otvet2;
                btn[2] = otvet3;

                for (int i = 0; i < 3; i++)
                    btn[i].Text = "";

                    


                if (stroki.Length > 0)
                    otvet1.Text = stroki[0];
                if (stroki.Length > 1)
                    otvet2.Text = stroki[1];
                if (stroki.Length > 2)
                    otvet3.Text = stroki[2];


                for (int i = 0; i < 3; i++)
                {
                    if (btn[i].Text == "") 
                    {
                        btn[i].Visible = false;
                    }
                }
            }
            catch (Exception) { }
        }
     

        void next()
        {
            nomerVoprosa = nomerVoprosa + 1;

            if (nomerVoprosa == 2)
            {
                drawPic("Это кто");
            }
            else if (nomerVoprosa == 3)
            {
                drawPic("Что за аномалия");
            }
            else if (nomerVoprosa == 4)
            {
                drawPic("maxresdefault");
            }
            
            else
            {
           //     MessageBox.Show("Winner");
            }
        }



        private void VoprosForm1_Load(object sender, EventArgs e)
        {

        }
      


        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            next();
            //MessageBox.Show("Ты не прав");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            next();
            //MessageBox.Show("Ты не прав");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Winner");
            next();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter f = new Filter();
            f.ShowDialog();
        }
    }

}
