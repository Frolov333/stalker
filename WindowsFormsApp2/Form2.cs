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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Персонажи.txt",
                         Environment.NewLine +
                         textBox1.Text + ", " +
                         textBox2.Text + ", " +
                         NameBox1.Text);

            if(FileName !="")
            {
              System.IO.File.Copy(FileName, "../../Kartinki/" + textBox2.Text + ".jpg");
            }
           
        }
        string FileName = "";
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() ==
    DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
            if (openFileDialog1.ShowDialog() ==
                DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
        }
    }
}
